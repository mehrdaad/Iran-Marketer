﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pikad.Framework.Infra.Utility;
using RestSharp;
using IranMarketer.App.Component.Helper;
using IranMarketer.App.Component.Model;
using IranMarketer.App.Component.Provider;
using IranMarketer.Common.Utility;
using IranMarketer.Domain.Entity;
using IranMarketer.Domain.Enum;
using IranMarketer.Domain.Filters;

namespace IranMarketer.App.Controllers
{
    public class TseEquityFeeSettingController : BaseController
    {

        [HttpPost]
        public ActionResult SaveSetting(TseEquityFeeSetting setting)

        {
            try
            {
                setting.ValidFrom = DateTime.Now;
                var req = ApiHelper.Request(ApiAddressProvider.TradeFeeSettingApi + "SaveTseEquityFeeSetting", Method.POST);
                req.AddJsonBody(new ApiRequest<TseEquityFeeSetting>
                {
                    Entity = setting
                });
               
                var res = req.Exec<ApiResponse<object>>(this);
                return Json(res.Data);
            }
            catch (Exception ex)
            {

                return Json(new ApiResponse<object>
                {
                    BRuleCode = 1,
                    Message = RuleExceptionCodeCommon.OtherError.GetEnumDescription()

                });
            }
        }

        [HttpPost]

        public JsonResult GetLastSetting()
        {

            try
            {
                var date = DateTime.Now;
                var req = ApiHelper.Request(ApiAddressProvider.TradeFeeSettingApi + "GetCurrentTseEquityFeeSetting", Method.POST);
                req.AddJsonBody(new BaseReportFilter<GeneralSettingFilter>
                {
                    ReportFilter = new GeneralSettingFilter
                    {
                        Date = date
                    }
                });

                var res = req.Exec<ApiResponse<TseEquityFeeSetting>>(this);
                return Json(res.Data.Result);
            }
            catch (Exception ex)
            {
                return Json(new ApiResponse<object>
                {
                    BRuleCode = 1,
                    Message = RuleExceptionCodeCommon.OtherError.GetEnumDescription()

                });
            }


        }


    }
}