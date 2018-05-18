﻿using System;
using System.Linq;
using System.Web.Mvc;
using RANSUROTTO.BLOG.Admin.Models.Customers;
using RANSUROTTO.BLOG.Core.Domain.Customers.AttributeName;
using RANSUROTTO.BLOG.Core.Domain.Customers.Setting;
using RANSUROTTO.BLOG.Framework.Kendoui;
using RANSUROTTO.BLOG.Services.Common;
using RANSUROTTO.BLOG.Services.Customers;
using RANSUROTTO.BLOG.Services.Helpers;
using RANSUROTTO.BLOG.Services.Localization;

namespace RANSUROTTO.BLOG.Admin.Controllers
{
    public class OnlineCustomerController : BaseAdminController
    {

        #region Fields

        private readonly ICustomerService _customerService;
        private readonly IDateTimeHelper _dateTimeHelper;
        private readonly CustomerSettings _customerSettings;
        private readonly ILocalizationService _localizationService;

        #endregion

        #region Constructor

        public OnlineCustomerController(ICustomerService customerService, IDateTimeHelper dateTimeHelper, CustomerSettings customerSettings, ILocalizationService localizationService)
        {
            _customerService = customerService;
            _dateTimeHelper = dateTimeHelper;
            _customerSettings = customerSettings;
            _localizationService = localizationService;
        }

        #endregion

        #region Methods

        public virtual ActionResult List()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult List(DataSourceRequest command)
        {
            var customers = _customerService.GetOnlineCustomers(
                    DateTime.UtcNow.AddMinutes(-_customerSettings.OnlineCustomerMinutes),
                    null,
                    command.Page - 1,
                    command.PageSize);
            var gridModel = new DataSourceResult
            {
                Data = customers.Select(x => new OnlineCustomerModel
                {
                    Id = x.Id,
                    CustomerInfo = x.IsRegistered() ? x.Email : _localizationService.GetResource("Admin.Customers.Guest"),
                    LastIpAddress = x.LastIpAddress,
                    //Location = _geoLookupService.LookupCountryName(x.LastIpAddress),
                    LastActivityDate = _dateTimeHelper.ConvertToUserTime(x.LastActivityDateUtc, DateTimeKind.Utc),
                    LastVisitedPage = _customerSettings.LastVisitedPage ?
                        x.GetAttribute<string>(SystemCustomerAttributeNames.LastVisitedPage) :
                        _localizationService.GetResource("Admin.Customers.OnlineCustomers.Fields.LastVisitedPage.Disabled")
                }),
                Total = customers.TotalCount
            };

            return Json(gridModel);
        }

        #endregion

    }
}