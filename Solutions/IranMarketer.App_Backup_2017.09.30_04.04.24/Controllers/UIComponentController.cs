﻿//using Kendo.Mvc.Extensions;
//using Kendo.Mvc.UI;
using RestSharp;
using IranMarketer.App.Component.Helper;
using IranMarketer.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Pikad.Framework.Infra.Utility;
using IranMarketer.App.Component.Model;
using IranMarketer.App.Component.Provider;
using IranMarketer.Common.Utility;
using IranMarketer.Domain.Enum;
using IranMarketer.Domain.Filters;
using PersonalityRole = IranMarketer.Domain.Enum.PersonalityRole;



namespace IranMarketer.App.Controllers
{

    public class UIComponentController : BaseController
    {
        public ApiHelper ApiHelper = new ApiHelper();

        // GET: Regions (countries)


        public JsonResult GetRequestSettlementType(bool? addAll = false)
        {
            try
            {
                var list = Enum.GetValues(typeof(RequestSettlementType)).Cast<RequestSettlementType>();

                var dto = list.Select(l => new
                {
                    RequestSettlementValue = (int)l,
                    RequestSettlementTitle = l.GetEnumDescription(),
                }).ToList();
                if (addAll.SafeBool())
                {
                    dto.Add(new { RequestSettlementValue = AddAllValue, RequestSettlementTitle = AddAllTitle });
                }


                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.RequestSettlementTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetAccountBalanaceRemainType()
        {
            try
            {
                var list = Enum.GetValues(typeof(AccountBalanaceRemainType)).Cast<AccountBalanaceRemainType>();

                var dto = list.Select(l => new
                {
                    AccountBalanceRemainValue = (int)l,
                    AccountBalanceRemainTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.AccountBalanceRemainValue), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetRequestTransactionStateType(bool? addAll = false)
        {
            try
            {
                var list = Enum.GetValues(typeof(RequestTransactionState)).Cast<RequestTransactionState>();

                var dto = list.Select(l => new
                {
                    RequestTransactionStateValue = (int)l,
                    RequestTransactionStateTitle = l.GetEnumDescription(),
                }).ToList();
                if (addAll.SafeBool())
                {
                    dto.Add(new { RequestTransactionStateValue = AddAllValue, RequestTransactionStateTitle = AddAllTitle });
                }
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.RequestTransactionStateTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public JsonResult GetRequestTransactionType(bool? addAll = false)
        {
            try
            {
                var list = Enum.GetValues(typeof(Domain.Enum.RequestTransactionType)).Cast<Domain.Enum.RequestTransactionType>();

                var dto = list.Select(l => new
                {
                    RequestTransactionTypeValue = (int)l,
                    RequestTransactionTypeTitle = l.GetEnumDescription(),
                }).ToList();

                if (addAll.SafeBool())
                {
                    dto.Add(new { RequestTransactionTypeValue = AddAllValue, RequestTransactionTypeTitle = AddAllTitle });
                }
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.RequestTransactionTypeTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        public JsonResult GetCountries(string text = "")
        {
            try
            {
                var lst = new List<Region>();
                var req = ApiHelper.Request(ApiAddressProvider.RegionApi + "GetRegions/{filter}/{regiontype}", Method.POST);
                if (string.IsNullOrEmpty(text))
                {
                    req.AddParameter("filter", text);
                    req.AddParameter("regiontype", RegionType.Country);
                }
                else
                {
                    req.AddParameter("filter", string.Empty);
                    req.AddParameter("regiontype", RegionType.Country);
                }
                var res = req.Exec<ApiResponse<List<Region>>>(this);
                lst = res.Data.Result;
                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // GET: Regions (cities)
        public JsonResult GetCities(string text = "", bool? addAll = false)
        {
            try
            {
                var lst = new List<Region>();
                var req = ApiHelper.Request(ApiAddressProvider.RegionApi + "GetRegionsByFilter?filter={filter}&regionType={regionType}", Method.POST);
                req.AddParameter("filter", text, ParameterType.UrlSegment);
                req.AddParameter("regionType", (int)RegionType.State, ParameterType.UrlSegment);

                var res = req.Exec<ApiResponse<List<Region>>>(this);
                if (res.Data != null)
                    lst = res.Data.Result;
                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public JsonResult GetBankAccountTypes(string text)
        {
            try
            {
                var lst = new List<EnumResponseDto>();
                var req = ApiHelper.Request(ApiAddressProvider.CommonApi + "GetBankAccountTypeEnum", Method.GET);
                var res = req.Exec<ApiPagedCollectionResponse<EnumResponseDto>>(this);
                if (res.Data != null)
                {
                    lst = res.Data.Result;
                    if (!string.IsNullOrEmpty(text))
                    {
                        lst = lst.Where(x => x.Title.Contains(text)).ToList();
                    }
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetEducationDegrees(string text)
        {
            try
            {
                var lst = new List<EnumResponseDto>();
                var req = ApiHelper.Request(ApiAddressProvider.CommonApi + "GetEducationDegreeEnum", Method.GET);
                var res = req.Exec<ApiPagedCollectionResponse<EnumResponseDto>>(this);
                if (res.Data != null)
                {
                    lst = res.Data.Result;
                    if (!string.IsNullOrEmpty(text))
                    {
                        lst = lst.Where(x => x.Title.Contains(text)).ToList();
                    }
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetJobTitles(string text)
        {
            try
            {
                var lst = new List<EnumResponseDto>();
                var req = ApiHelper.Request(ApiAddressProvider.CommonApi + "GetJobTitleEnum", Method.GET);
                var res = req.Exec<ApiPagedCollectionResponse<EnumResponseDto>>(this);
                if (res.Data != null)
                {
                    lst = res.Data.Result;
                    if (!string.IsNullOrEmpty(text))
                    {
                        lst = lst.Where(x => x.Title.Contains(text)).ToList();
                    }
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetJobPositions(string text)
        {
            try
            {
                var lst = new List<EnumResponseDto>();
                var req = ApiHelper.Request(ApiAddressProvider.CommonApi + "GetJobPositionEnum", Method.GET);
                var res = req.Exec<ApiPagedCollectionResponse<EnumResponseDto>>(this);
                if (res.Data != null)
                {
                    lst = res.Data.Result;
                    if (!string.IsNullOrEmpty(text))
                    {
                        lst = lst.Where(x => x.Title.Contains(text)).ToList();
                    }
                }

                return Json(lst, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public JsonResult GetRolesDropDownList(string text)
        {
            try
            {
                var req = ApiHelper.Request(ApiAddressProvider.AccountApi + "GetRoles", Method.POST);
                var res = req.Exec<ApiPagedCollectionResponse<Domain.DTO.ApplicationRoleDto>>(this);

                var dto = res.Data.Result.Select(l => new
                {
                    RoleValue = l.Name,
                    RoleTitle = l.Name,


                }).ToList();

                //  res = Helper.AddAllToDropDown(res);

                if (!string.IsNullOrEmpty(text))
                {
                    dto = dto.Where(p => p.RoleTitle.Contains(text)).ToList();
                }

                return Json(dto.OrderBy(x => x.RoleTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public JsonResult GetBranchTypes()
        {
            try
            {
                var list = Enum.GetValues(typeof(BranchType)).Cast<BranchType>();

                var dto = list.Select(l => new
                {
                    BranchTypeValue = (int)l,
                    BranchTypeTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.BranchTypeTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public JsonResult GetUserStatusType()
        {
            try
            {
                var list = Enum.GetValues(typeof(UserStatus)).Cast<UserStatus>();

                var dto = list.Select(l => new
                {
                    UserStatusValue = (int)l,
                    UserStatusTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.UserStatusTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetAccountStatusType()
        {
            try
            {
                var list = new List<AccountStatus>
                {
                    AccountStatus.Active,
                    AccountStatus.InActive
                };

                var dto = list.Select(l => new
                {
                    UserStatusValue = (int)l,
                    UserStatusTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.UserStatusTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public JsonResult GetFundSizeType()
        {
            try
            {
                var list = Enum.GetValues(typeof(FundSize)).Cast<FundSize>();

                var dto = list.Select(l => new
                {
                    FundSizeValue = (int)l,
                    FundSizeTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.FundSizeTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public JsonResult GetDividendsGuaranteeType()
        {
            try
            {
                var list = Enum.GetValues(typeof(DividendsGuaranteeType)).Cast<DividendsGuaranteeType>();

                var dto = list.Select(l => new
                {
                    DividendsGuaranteeTypeValue = (int)l,
                    DividendsGuaranteeTypeTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.DividendsGuaranteeTypeTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetFundType()
        {
            try
            {
                var list = Enum.GetValues(typeof(FundType)).Cast<FundType>();

                var dto = list.Select(l => new
                {
                    FundTypeValue = (int)l,
                    FundTypeTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.FundTypeTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public JsonResult GetOrgenizationType()
        {
            try
            {
                var list = Enum.GetValues(typeof(OrgenizationType)).Cast<OrgenizationType>();

                var dto = list.Select(l => new
                {
                    OrgenizationTypeValue = (int)l,
                    OrgenizationTypeTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.OrgenizationTypeTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public JsonResult GetFundDividendsPeriodType()
        {
            try
            {
                var list = Enum.GetValues(typeof(FundDividendsPeriod)).Cast<FundDividendsPeriod>();

                var dto = list.Select(l => new
                {
                    FundDividendsPeriodValue = (int)l,
                    FundDividendsPeriodTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.FundDividendsPeriodTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetPageTypes(string text = "")
        {
            try
            {
                var req = ApiHelper.Request(ApiAddressProvider.CommonApi + "GetPageTypeEnum", Method.GET);
                var res = req.Exec<ApiPagedCollectionResponse<EnumResponseDto>>(this);

                var dto = res.Data.Result.Select(l => new
                {
                    PageTypesValue = l.Code,
                    PageTypesTitle = l.Title,
                }).ToList();

                if (!string.IsNullOrEmpty(text))
                {
                    dto = dto.Where(x => x.PageTypesTitle.Contains(text)).ToList();
                }


                return Json(dto, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public JsonResult GetPersonalityRoleType()
        {
            try
            {
                var list = Enum.GetValues(typeof(PersonalityRole)).Cast<PersonalityRole>();

                var dto = list.Select(l => new
                {
                    PersonalityRoleValue = (int)l,
                    PersonalityRoleTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.PersonalityRoleTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetPartyType(bool? addAll = false)
        {
            try
            {
                var list = new List<PartyType>
                {
                    PartyType.Institutional,
                    PartyType.Retail
                };

                var dto = list.Select(l => new
                {
                    PartyTypeValue = (int)l,
                    PartyTypeTitle = l.GetEnumDescription(),
                }).ToList();

                if (addAll.SafeBool())
                {
                    dto.Add(new { PartyTypeValue = AddAllValue, PartyTypeTitle = AddAllTitle });
                }
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.PartyTypeTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetTradeTypes(bool? addAll = false)
        {
            try
            {
                var list = new List<SecurityTransactionType>
                {
                    SecurityTransactionType.Buy,
                    SecurityTransactionType.Sell
                };

                var dto = list.Select(l => new
                {
                    TradeTypeValue = (int)l,
                    TradeTypeTitle = l.GetEnumDescription(),
                }).ToList();

                if (addAll.SafeBool())
                {
                    dto.Add(new { TradeTypeValue = AddAllValue, TradeTypeTitle = AddAllTitle });
                }
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.TradeTypeValue), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetVoucherInsertModeType()
        {
            try
            {
                var list = new List<VoucherInsertMode>
                {
                    VoucherInsertMode.Automatic,
                    VoucherInsertMode.Manual
                };

                var dto = list.Select(l => new
                {
                    Value = (int)l,
                    Title = l.GetEnumDescription(),
                }).ToList();

                return Json(dto.OrderBy(x => x.Value), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetVoucherCategories(bool? addAll = false)
        {
            try
            {
                var list = new List<VoucherCategoryEnum>
                {
                    VoucherCategoryEnum.General,
                    VoucherCategoryEnum.BankDepositProfitReceive,
                    VoucherCategoryEnum.BankTransfer,
                    VoucherCategoryEnum.BondProfitCashFlow,
                    VoucherCategoryEnum.BondTradeClearingAndSettlementCashFlow,
                    VoucherCategoryEnum.CapitalIncreseApply,
                    VoucherCategoryEnum.ConfirmRedemptionRequest,
                    VoucherCategoryEnum.ConfirmSubscriptionRequest,
                    VoucherCategoryEnum.DailyCalculation,
                    VoucherCategoryEnum.EquityDividendApply,
                    VoucherCategoryEnum.EquityProfiBondTradeClearingAndSettlementCashFlow,
                    VoucherCategoryEnum.DailyTrade,
                    VoucherCategoryEnum.FixedIncomeTrade,
                    VoucherCategoryEnum.IPORequest,
                    VoucherCategoryEnum.RightPayment,
                    VoucherCategoryEnum.PaymentToInvestors,
                    VoucherCategoryEnum.PublicCashFlow,
                    VoucherCategoryEnum.OtherFundCostPayment,
                    VoucherCategoryEnum.SubscriptionRequest,
                    VoucherCategoryEnum.SubscriptionRequestPayBack,
                    VoucherCategoryEnum.UnknownPayment,
                    VoucherCategoryEnum.UnknownPaymentPayBack,
                    VoucherCategoryEnum.TransferBetweenAccounts,
                    VoucherCategoryEnum.OpeningAccounts,
                    VoucherCategoryEnum.ClosingAccounts,
                    VoucherCategoryEnum.BoardMemberCostPayment,
                    VoucherCategoryEnum.AnnualySoftwareCost
                };

                var dto = list.Select(l => new
                {
                    Value = (int)l,
                    Title = l.GetEnumDescription(),
                }).ToList();
                if (addAll.SafeBool())
                {
                    dto.Add(new { Value = AddAllValue, Title = AddAllTitle });
                }
                return Json(dto.OrderBy(x => x.Value), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetAdjustedPriceType()
        {
            try
            {
                var list = Enum.GetValues(typeof(AdjustedPriceType)).Cast<AdjustedPriceType>();

                var dto = list.Select(l => new
                {

                    AdjustedPriceTypeValue = (int)l,
                    AdjustedPriceTypeTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.AdjustedPriceTypeTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public JsonResult GetAdjustedPriceReason()
        {
            try
            {
                var list = Enum.GetValues(typeof(AdjustedPriceReason)).Cast<AdjustedPriceReason>();

                var dto = list.Select(l => new
                {

                    AdjustedPriceReasonValue = (int)l,
                    AdjustedPriceReasonTitle = l.GetEnumDescription(),
                }).ToList();
                //  res = Helper.AddAllToDropDown(res);
                return Json(dto.OrderBy(x => x.AdjustedPriceReasonTitle), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetCustomerPaymentTypes()
        {
            try
            {
                var list = Enum.GetValues(typeof(CustomerPaymentType)).Cast<CustomerPaymentType>();
                var dto = list.Select(l => new
                {
                    Type = (int)l,
                    Title = l.GetEnumDescription(),
                }).ToList();

                dto.Add(new { Type = AddAllValue, Title = AddAllTitle });
                return Json(dto.OrderBy(x => x.Type), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
        public JsonResult GetCashFlowTransactionType(bool? addAll = false)
        {
            try
            {
                var list = new List<CashFlowTransactionType>
                {
                    CashFlowTransactionType.Payment,
                    CashFlowTransactionType.Receive,
                    CashFlowTransactionType.Transfer
                };

                var dto = list.Select(l => new
                {
                    Value = (int)l,
                    Title = l.GetEnumDescription(),
                }).ToList();
                if (addAll.SafeBool())
                {
                    dto.Add(new { Value = AddAllValue, Title = AddAllTitle });
                }
                return Json(dto.OrderBy(x => x.Value), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetCashFlowTransactionState(bool? addAll = false)
        {
            try
            {
                var list = new List<CashFlowState>
                {
                    CashFlowState.Final,
                    CashFlowState.Draft
                };

                var dto = list.Select(l => new
                {
                    Value = (int)l,
                    Title = l.GetEnumDescription(),
                }).ToList();
                if (addAll.SafeBool())
                {
                    dto.Add(new { Value = AddAllValue, Title = AddAllTitle });
                }
                return Json(dto.OrderBy(x => x.Value), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult GetCashFlowTransactionCategory(bool? addAll = false)
        {
            try
            {
                var list = new List<CashFlowCategory>
                {
                    CashFlowCategory.BankTransfer,
                    CashFlowCategory.BankDepositProfitReceive,
                    CashFlowCategory.BondProfitCashFlow,
                    CashFlowCategory.ClearingAndSettlementCashFlow,
                    CashFlowCategory.PaymentstoInvestors,
                    CashFlowCategory.CostPayments,
                    CashFlowCategory.Public,
                    CashFlowCategory.UnknownSourcePayments
                };

                var dto = list.Select(l => new
                {
                    Value = (int)l,
                    Title = l.GetEnumDescription(),
                }).ToList();
                if (addAll.SafeBool())
                {
                    dto.Add(new { Value = AddAllValue, Title = AddAllTitle });
                }
                return Json(dto.OrderBy(x => x.Value), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}