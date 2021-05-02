using System.Collections.Generic;

namespace EATestAutomation
{
    public class JsonRootObject
    {
        //   internal int id;
        public string ARTICLE_NUMBER { get; set; }
        public string id { get; set; }
        public string blobRelativePath { get; set; }
        public List<SapUnit> SapUnitofmeasure { get; set; }
        //   public List<SapUnit1> SapAdditionalupcs { get; set; }
        //   public List<SapUnit3> SapBannernames { get; set; }
        //   public int ARTICLE_NUMBER { get; internal set; }
    }
}

   public class SapUnit
   {
//        //public string ARTICLE_NUMBER { get; set; }
//        //public string id { get; set; }
//        //public string blobRelativePath { get; set; }
       public string UNITOFMEASURE { get; set; }
//        public string MAINUPC { get; set; }
//        public string UPC_TYPE { get; set; }
//        public string NUMERATOR { get; set; }
//        public string DENOMENATOR
//        { get; set; }
//        public string UNITDIMENSION
//        { get; set; }
//        public string UNITOFWEIGHT
//        { get; set; }
//        public string GROSSWEIGHT
//        { get; set; }
//        public string LENGTH
//        { get; set; }
//        public string WIDTH
//        { get; set; }
//        public string HEIGHT
//        { get; set; }
//        public string VOLUME
//        { get; set; }

//        public string VOLUMEUNIT
//        { get; set; }
//        public string gtin
//        { get; set; }
//        public string gln
//        { get; set; }
//        public string isSellable
//        { get; set; }
   }
//    public class SapUnit1
//    {
//        public string UNITOFMEASURE
//        { get; set; }
//        public string MAINUPC
//        { get; set; }
//        public string UPC_TYPE
//        { get; set; }
//        public string NUMERATOR
//        { get; set; }
//        public string DENOMENATOR
//        { get; set; }
//        public string UNITDIMENSION
//        { get; set; }
//        public string UNITOFWEIGHT { get; set; }
//        public string GROSSWEIGHT
//        { get; set; }
//        public string LENGTH
//        { get; set; }
//        public string WIDTH
//        { get; set; }
//        public string HEIGHT
//        { get; set; }
//        public string VOLUME
//        { get; set; }
//        public string VOLUMEUNIT
//        { get; set; }
//        public string gtin { get; set; }
//        public string gln
//        { get; set; }
//        public string isSellable { get; set; }
//    }
//    public class SapUnit2
//    {
//        public string UNITOFMEASURE
//        { get; set; }
//        public string MAINUPC
//        { get; set; }
//        public string UPC_TYPE
//        { get; set; }
//        public string NUMERATOR
//        { get; set; }
//        public string DENOMENATOR
//        { get; set; }
//        public string UNITDIMENSION
//        { get; set; }
//        public string UNITOFWEIGHT
//        { get; set; }
//        public string GROSSWEIGHT
//        { get; set; }
//        public string LENGTH
//        { get; set; }
//        public string WIDTH
//        { get; set; }
//        public string HEIGHT
//        { get; set; }
//        public string VOLUME
//        { get; set; }
//        public string VOLUMEUNIT
//        { get; set; }
//        public string gtin
//        { get; set; }
//        public string gln
//        { get; set; }
//        public string isSellable
//        { get; set; }
//    }
//    public class SapUnit3 {
//        public string SALES_ORGANIZATION { get; set; }
//    }

//}

//*/

////public string
////{ get; set; }
////{ get; set; }
////{ get; set; }
////{ get; set; }
////{ get; set; }
////    }



////public class SapTemperaturedescription
////{
////    public string LANGUAGE { get; set; }
////    public string DESCRIPTION { get; set; }
////}

////public class SapArticlebasicdata
////{
////    public List<object> SapCountrydescriptions { get; set; }
////    public List<object> SapRegiondescriptions { get; set; }
////    public List<object> SapPrivatelabeldescriptions { get; set; }
////    public List<object> SapHazardousitemdescriptions { get; set; }
////    public List<object> SapContainerdescriptions { get; set; }
////    public List<object> SapIngredients { get; set; }
////    public List<SapTemperaturedescription> SapTemperaturedescriptions { get; set; }
////    public string ARTICLE_TYPE { get; set; }
////    public string MERCHANDISE_CATEGORY { get; set; }
////    public string BASE_UNIT_OF_MEASURE { get; set; }
////    public double NET_WEIGHT { get; set; }
////    public object CONTAINER_REQUIREMENTS { get; set; }
////    public object PRODUCT_HIERARCHY { get; set; }
////    public object PACKAGING_MATERIAL_TYPE { get; set; }
////    public object EMPTIES_BILL_OF_MATERIAL { get; set; }
////    public object EXTERNAL_MERCHANDISE_CATEGORY { get; set; }
////    public string ARTICLE_CATEGORY { get; set; }
////    public string ARTICLE_TAX_CLASSIFICATION { get; set; }
////    public string CONTENT_UNIT { get; set; }
////    public double NET_CONTENTS { get; set; }
////    public int COMPARISON_PRICE_UNIT { get; set; }
////    public double GROSS_CONTENTS { get; set; }
////    public object DANGEROUS_GOODS_INDICATOR { get; set; }
////    public object DRUG_ID_NUMBER_DIN { get; set; }
////    public object DUNS_SUFFIX { get; set; }
////    public object TRAY_NUMBERS { get; set; }
////    public string LABOUR_COMMODITY_CODE { get; set; }
////    public object SOAKER_PAD_QUANTITY { get; set; }
////    public object TARE_CODE { get; set; }
////    public string KOSHER { get; set; }
////    public object CATCH_WEIGHT_ITEM { get; set; }
////    public int DAYS_FOR_OLD_STOCK_CALCULATION { get; set; }
////    public string NUTRITION_DATA_REQUIRED { get; set; }
////    public string WILL_BE_USED_AS_ITRADE_ITEMS { get; set; }
////    public object RECLAMATION_ITEM { get; set; }
////    public object HAZARDOUS_ITEM { get; set; }
////    public object CERTIFIED_ORGANIC { get; set; }
////    public string RETAIL_PACK_QUANTITY { get; set; }
////    public double ALTERNATE_CONTENT { get; set; }
////    public object ALTERNATE_CONTENT_UNIT { get; set; }
////    public int CASE_SALES_PACK { get; set; }
////    public object RSC_CREDIT_NON_RETURNABLE_FLAG { get; set; }
////    public object ARTICLE_IDENTIFIER { get; set; }
////    public object COST_CHANGE_DATE_OVERRIDE { get; set; }
////    public object GLUTEN_FREE { get; set; }
////    public object SCAN_BASED_TRADING_GROUP_ID { get; set; }
////    public string IPG_CODE_VALUE { get; set; }
////    public object PRECURSOR_IDENTIFIER { get; set; }
////    public object ETHNIC_CODE { get; set; }
////    public object HALAL { get; set; }
////    public string ASSORTMENT_LIST_TYPE { get; set; }
////    public object ABC_INDICATOR { get; set; }
////    public object ARTICLE_COUNTRY_OF_ORIGIN { get; set; }
////    public object ARTICLE_REGION_OF_ORIGIN { get; set; }
////    public double VALUATION_MARGIN { get; set; }
////    public double MINIMUM_TEMPERATURE { get; set; }
////    public double MAXIMUM_TEMPERATURE { get; set; }
////    public string TEMPERATURE_UNIT { get; set; }
////    public string VALUATIONCLASS { get; set; }
////    public string PURCHASEUNITOFMEASURE { get; set; }
////    public string SALESUNITOFMEASURE { get; set; }
////    public object PRIVATELABEL { get; set; }

////}

////public class SapWholesaleuom
////{
////    public string UNITOFMEASURE { get; set; }
////}

////public class SapRegionalbasicdata
////{
////    public string SALES_ORGANIZATION { get; set; }
////    public string LABOUR_COMMODITY_CODE { get; set; }
////    public object SOAKER_PAD_QUANTITY { get; set; }
////    public object TARE_CODE { get; set; }
////    public object GLUTEN_FREE { get; set; }
////    public object TRAY_NUMBERS { get; set; }
////    public object CATCH_WEIGHT_ITEM { get; set; }
////    public object COST_CHANGE_DATE_OVERRIDE { get; set; }
////    public object RSC_CREDIT_NON_RETURNABLE_FLAG { get; set; }
////    public string CANSELLWHOLESALE { get; set; }
////    public List<SapWholesaleuom> SapWholesaleuoms { get; set; }
////    public object IS_SINGLE_PICK { get; set; }
////}

//public class SapArticledescription
//{
//    public string LANGUAGE { get; set; }
//    public string VALUE { get; set; }
//}

//public class SapConsumerdescription
//{
//    public object BRAND_EN { get; set; }
//    public string PRODUCT_EN { get; set; }
//    public object FLAVOR_EN { get; set; }
//    public string SIZE_EN { get; set; }
//    public object BRAND_FR { get; set; }
//    public string PRODUCT_FR { get; set; }
//    public string FLAVOR_FR { get; set; }
//    public string SIZE_FR { get; set; }
//}

//public class SapLabeldescription
//{
//    public string LANGUAGE { get; set; }
//    public string UNITOFMEASURE { get; set; }
//    public string DESCRIPTION { get; set; }
//}

//public class SapTillreceiptdescription
//{
//    public string LANGUAGE { get; set; }
//    public string UNITOFMEASURE { get; set; }
//    public string DESCRIPTION { get; set; }
//}

//public class SapDescriptions
//{
//    public object REGION { get; set; }
//    public List<SapArticledescription> SapArticledescriptions { get; set; }
//    public List<object> SapWebdescriptions { get; set; }
//    public SapConsumerdescription SapConsumerdescription { get; set; }
//    public List<object> SapBranddescriptions { get; set; }
//    public List<SapLabeldescription> SapLabeldescriptions { get; set; }
//    public List<SapTillreceiptdescription> SapTillreceiptdescriptions { get; set; }
//    public List<object> SapQuebecscaledescriptions { get; set; }
//    public List<object> SapScaleline1descriptions { get; set; }
//    public List<object> SapScaleline2descriptions { get; set; }
//    public List<object> SapScaleline3descriptions { get; set; }
//    public string LANGUAGE { get; set; }
//    public string DESCRIPTION { get; set; }
//}

//public class SapAdditionalupc
//{
//    public string UPC { get; set; }
//    public List<object> SapPlumformatcodes { get; set; }
//    public List<object> SapMadeinprovinces { get; set; }
//    public string UPC_TYPE { get; set; }
//}

//public class SapUnitofmeasure
//{
//    public object REGION { get; set; }
//    public string UNITOFMEASURE { get; set; }
//    public string MAINUPC { get; set; }
//    public string GLN { get; set; }
//    public string GTIN { get; set; }
//    public string UPC_TYPE { get; set; }
//    public List<SapAdditionalupc> SapAdditionalupcs { get; set; }
//    public string UNITDIMENSION { get; set; }
//    public string UNITOFWEIGHT { get; set; }
//    public double GROSSWEIGHT { get; set; }
//    public double LENGTH { get; set; }
//    public double WIDTH { get; set; }
//    public double HEIGHT { get; set; }
//    public double VOLUME { get; set; }
//    public string VOLUMEUNIT { get; set; }
//    public List<object> SapPlumformatcodes { get; set; }
//    public int NUMERATOR { get; set; }
//    public int DENOMENATOR { get; set; }
//    public List<object> SapMadeinprovinces { get; set; }
//}

//public class SapPurchasing
//{
//    public string SALES_ORGANIZATION { get; set; }
//    public string VENDOR_NUMBER { get; set; }
//    public string PURCHASE_ORDER_UNIT_OF_MEASURE { get; set; }
//    public object VENDOR_ARTICLE_NUMBER { get; set; }
//    public object VENDOR_SUBRANGE { get; set; }
//    public object REGULAR_VENDOR { get; set; }
//    public string PURCHASING_ORGANIZATION { get; set; }
//    public string PURCHASE_INFO_RECORD_CATEGORY { get; set; }
//    public string SITE_NUMBER { get; set; }
//    public string PURCHASING_GROUP { get; set; }
//    public string CURRENCY { get; set; }
//    public double MINIMUM_PURCHASE_ORDER_QTY { get; set; }
//    public double STANDARD_PURCHASE_ORDER_QTY { get; set; }
//    public int PLANNED_DELIVERY_TIME_IN_DAYS { get; set; }
//    public double OVERDELIVERY_TOLERANCE_LIMIT { get; set; }
//    public string UNLIMITED_OVERDELIVERY_ALLOWED { get; set; }
//    public double UNDERDELIVERY_TOLERANCE_LIMIT { get; set; }
//    public double NET_PRICE_IN_PURCH_INFO_RECORD { get; set; }
//    public int PRICE_UNIT { get; set; }
//    public string ORDER_PRICE_UNIT_PURCHASING { get; set; }
//    public string BASED_INVOICE_VERIFICATION { get; set; }
//    public object CONDITION_GROUP_WITH_VENDOR { get; set; }
//    public object SETTLEMENT_GROUP_1_PURCHASING { get; set; }
//    public string SHIPPING_INSTRUCTIONS { get; set; }
//    public string CONFIRMATION_CONTROL_KEY { get; set; }
//    public string PRICE_DETERMINATION_DATE_CTRL { get; set; }
//    public string INCOTERMS_PART_1 { get; set; }
//    public string INCOTERMS_PART_2 { get; set; }
//    public string NO_EVALUATED_RECEIPTSETTLEMENT { get; set; }
//    public object SETTLEMENT_GROUP_2 { get; set; }
//    public object SETTLEMENT_GROUP_3 { get; set; }
//    public object NOT_RELEVANT_SUBSEQ_SETTLEMENT { get; set; }
//    public string ROUNDING_PROFILE { get; set; }
//    public string UNIT_OF_MEASURE_GROUP { get; set; }
//}

//public class SapSourcing
//{
//    public string SALES_ORGANIZATION { get; set; }
//    public string SITE { get; set; }
//    public string SOURCE_LIST_RECORD_VALID_FROM { get; set; }
//    public string SOURCE_LIST_RECORD_VALID_TO { get; set; }
//    public string VENDOR_ACCOUNT_NUMBER { get; set; }
//    public string INDICATOR_FIXED_VENDOR { get; set; }
//    public string PURCHASING_ORGANIZATION { get; set; }
//}

//public class SapInstorelocation
//{
//    public string UPC { get; set; }
//    public string UNITOFMEASURE { get; set; }
//    public string AISLE { get; set; }
//    public string AISLETYPE { get; set; }
//    public string SIDE { get; set; }
//    public string AISLESECTION { get; set; }
//    public object SHELF { get; set; }
//    public string HASSALES { get; set; }
//}

//public class SapStore
//{
//    public string SALES_ORGANIZATION { get; set; }
//    public string REGION { get; set; }
//    public string SITE_NUMBER { get; set; }
//    public string SITENAME { get; set; }
//    public string SALESORGANIZATION { get; set; }
//    public string PURCHASINGORGANIZATION { get; set; }
//    public string DISTRIBUTIONCHANNEL { get; set; }
//    public string PURCHASING_GROUP { get; set; }
//    public string UNIT_OF_ISSUE { get; set; }
//    public object ARTICLE_RP_PROFILE { get; set; }
//    public string RP_TYPE { get; set; }
//    public object STOCK_PLANNER_ARTICLES_PLANNER { get; set; }
//    public int PLANNED_DELIVERY_TIME_IN_DAYS { get; set; }
//    public string PERIOD_INDICATOR { get; set; }
//    public double REORDER_POINT { get; set; }
//    public double SAFETY_STOCK { get; set; }
//    public double MAXIMUM_STOCK_LEVEL { get; set; }
//    public int MAXIMUM_STORAGE_PERIOD { get; set; }
//    public object MAXIMUM_STORAGE_PERIOD_UNIT { get; set; }
//    public string LOADING_GROUP { get; set; }
//    public object QUOTA_ARRANGEMENT_USAGE { get; set; }
//    public string GROUP_FOR_AVAILABILITY_CHECK { get; set; }
//    public string SOURCE_OF_SUPPLY { get; set; }
//    public string COUNTRY_OF_ORIGIN { get; set; }
//    public object PPC_PLANNING_CALENDAR { get; set; }
//    public object PLANNING_CYCLE { get; set; }
//    public string DEFAULT_STORAGE_LOCATION { get; set; }
//    public object UNIT_OF_MEASURE_GROUP { get; set; }
//    public string HANDLING_GROUP_WORKLOAD_CALC { get; set; }
//    public object EXCLUDED_FROM_MINIMUM { get; set; }
//    public string LABEL_QUANTITY { get; set; }
//    public object POS_AGE_VERIFY { get; set; }
//    public object POS_ITEM_RESTRICT_CODE { get; set; }
//    public object PRICE_REQUIRED { get; set; }
//    public string PRODUCT_GRADE { get; set; }
//    public object QUANTITY_REQUIRED { get; set; }
//    public string SIGNS_LABELS { get; set; }
//    public object VISUAL_VERIFY { get; set; }
//    public object A_48_HOUR_PRODUCT { get; set; }
//    public int PRORATION_QTY_LIMIT { get; set; }
//    public string PROFIT_CENTER { get; set; }
//    public string PROFIT_CENTER_DESCR_EN { get; set; }
//    public object PROFIT_CENTER_DESCR_FR { get; set; }
//    public object FORECAST_PROFILE { get; set; }
//    public string FORECAST_MODEL { get; set; }
//    public string REFERENCEARTICLECONSUMPTIONDT { get; set; }
//    public double REFARTCONSUMPTIONMULTIPLIER { get; set; }
//    public object REFERENCEARTICLEFORCONSUMPTION { get; set; }
//    public string DISCOUNT_FLAG { get; set; }
//    public string ASSORTMENT { get; set; }
//    public string VALID_TO_DATE { get; set; }
//    public string VALID_FROM_DATE { get; set; }
//    public string POSDEPARTMENTNUMBER { get; set; }
//    public string MINIMUMSHELFLIFE { get; set; }
//    public string MAXIMUMSHELFLIFE { get; set; }
//    public string MINIMUNACCEPTED { get; set; }
//    public string CUSTOMERSHELFLIFE { get; set; }
//    public string OSPRETAILERREGIONID { get; set; }
//    public string LOCATIONID { get; set; }
//    public List<SapInstorelocation> SapInstorelocations { get; set; }
//    public string PRIMARYVENDOR { get; set; }
//}

//public class SapReasonCode
//{
//    public string REASON_CODE { get; set; }
//    public string VALID_FROM { get; set; }
//    public string VALID_TO { get; set; }
//    public List<SapDescriptions> SapDescriptions { get; set; }
//}

//public class SapWarehous
//{
//    public string SALES_ORGANIZATION { get; set; }
//    public string REGION { get; set; }
//    public string WAREHOUSENUMBER { get; set; }
//    public string WAREHOUSENAME { get; set; }
//    public string SALESORGANIZATION { get; set; }
//    public string PURCHASINGORGANIZATION { get; set; }
//    public string DISTRIBUTIONCHANNEL { get; set; }
//    public string STOCKPLANNER { get; set; }
//    public string PURCHASINGGROUP { get; set; }
//    public string LOGISTICSGROUP { get; set; }
//    public string LOADINGGROUP { get; set; }
//    public string PLANNINGCYCLE { get; set; }
//    public string RPPROFILE { get; set; }
//    public string RPTYPE { get; set; }
//    public string PERIODINDICATOR { get; set; }
//    public string PLANNINGCALENDAR { get; set; }
//    public int PLANNEDDELIVERYTIME { get; set; }
//    public string AVAILABILITYCHECK { get; set; }
//    public object SITESPECIFICARTICLESTATUS { get; set; }
//    public string SITESPECIFICARTICLESTATVLDFRM { get; set; }
//    public string FORECASTPROFILE { get; set; }
//    public string FORECASTMODEL { get; set; }
//    public string UNITOFISSUE { get; set; }
//    public object QUOTAUSAGE { get; set; }
//    public object SOURCEOFSUPPLY { get; set; }
//    public object SHIPPINGINSTRUCTIONS { get; set; }
//    public object CONFIRMATIONCONTROLKEY { get; set; }
//    public object ROUNDINGPROFILE { get; set; }
//    public object A_48HOURPRODUCT { get; set; }
//    public object UNITGROUP { get; set; }
//    public double STANDARDQUANTITY { get; set; }
//    public int PRORATIONQUANTITYLIMIT { get; set; }
//    public object CATCHWEIGHT { get; set; }
//    public object DEFAULTSTORAGELOCATION { get; set; }
//    public double SAFETYSTOCK { get; set; }
//    public double ROUNDINGVALUE { get; set; }
//    public string ASSORTMENT { get; set; }
//    public string VALID_TO_DATE { get; set; }
//    public string VALID_FROM_DATE { get; set; }
//    public List<SapReasonCode> SapReasonCodes { get; set; }
//}

//public class SapBannername
//{
//    public string LANGUAGE { get; set; }
//    public string NAME { get; set; }
//}

//public class SapSale
//{
//    public string SALES_ORGANIZATION { get; set; }
//    public string DISTRIBUTION_CHANNEL { get; set; }
//    public object DISTRIBUTION_CHAIN_ART_STATUS { get; set; }
//    public string DISTR_CHAIN_SPEC_VALID_FROM { get; set; }
//    public string UNIT_OF_MEASURE_OF_DELIVERY { get; set; }
//    public string SALES_UNIT { get; set; }
//    public string ARTICLE_PRICING_GROUP { get; set; }
//    public object ACCOUNT_ASSIGNMENT_GROUP { get; set; }
//    public object DISTRIBUTION_CHANNEL_NAME { get; set; }
//    public object COMBINED_CONSUM_OR_REF_ARTICLE { get; set; }
//    public object STORE_INVETORY_MASTER_ITEM { get; set; }
//    public double AVERAGE_UNIT_WEIGHT { get; set; }
//    public string WEB_ONLINE_FLAG { get; set; }
//    public object TARE_CODE { get; set; }
//    public object WEB_AVAILABLE_FROM { get; set; }
//    public object WEB_AVAILABLE_TO { get; set; }
//    public object MUST_CARRY_FLAG { get; set; }
//    public int ONLINE_PORTION_ID { get; set; }
//    public string ONLINE_PORTION_QUANTITY { get; set; }
//    public object ONLINE_PORTION_DESCRIPTION { get; set; }
//    public object PROMOTIONAL_FAMILY_GROUPING { get; set; }
//    public object SOBEYS_NATIONAL_PHARMACY_GROUP { get; set; }
//    public object MAXIMUM_WEIGHT { get; set; }
//    public object MINIMUM_WEIGHT { get; set; }
//    public object NATIONALPHARMACYGROUP { get; set; }
//    public string LISTEDFROM { get; set; }
//    public string LISTEDTO { get; set; }
//    public object CATCHWEIGHTUNIT { get; set; }
//    public List<SapBannername> SapBannernames { get; set; }
//}

//public class SapArticledepartmentgrouping
//{
//    public string SALES_ORGANIZATION { get; set; }
//    public string SITE_GROUP { get; set; }
//    public string PROFIT_CENTER { get; set; }
//    public string POS_DEPARTMENT { get; set; }
//}

//public class SapRecycle1
//{
//    public object CODE { get; set; }
//    public double WEIGHT { get; set; }
//}

//public class SapRecycle2
//{
//    public object CODE { get; set; }
//    public double WEIGHT { get; set; }
//}

//public class SapRecycle3
//{
//    public object CODE { get; set; }
//    public double WEIGHT { get; set; }
//}

//public class SapRecycle4
//{
//    public object CODE { get; set; }
//    public double WEIGHT { get; set; }
//}

//public class SapRecycle5
//{
//    public object CODE { get; set; }
//    public double WEIGHT { get; set; }
//}

//public class SapRecycle6
//{
//    public object CODE { get; set; }
//    public double WEIGHT { get; set; }
//}

//public class SapRecycle7
//{
//    public object CODE { get; set; }
//    public double WEIGHT { get; set; }
//}

//public class SapRecycle8
//{
//    public object CODE { get; set; }
//    public double WEIGHT { get; set; }
//}

//public class SapRecycle9
//{
//    public object CODE { get; set; }
//    public double WEIGHT { get; set; }
//}

//public class SapRecycle10
//{
//    public object CODE { get; set; }
//    public double WEIGHT { get; set; }
//}

//public class SapNationalrecyclecodes
//{
//    public string REGION { get; set; }
//    public SapRecycle1 SapRecycle1 { get; set; }
//    public SapRecycle2 SapRecycle2 { get; set; }
//    public SapRecycle3 SapRecycle3 { get; set; }
//    public SapRecycle4 SapRecycle4 { get; set; }
//    public SapRecycle5 SapRecycle5 { get; set; }
//    public SapRecycle6 SapRecycle6 { get; set; }
//    public SapRecycle7 SapRecycle7 { get; set; }
//    public SapRecycle8 SapRecycle8 { get; set; }
//    public SapRecycle9 SapRecycle9 { get; set; }
//    public SapRecycle10 SapRecycle10 { get; set; }
//}

//public class SapQuebecrecyclecodes
//{
//    public string REGION { get; set; }
//    public List<object> SapRecycle1 { get; set; }
//    public List<object> SapRecycle2 { get; set; }
//    public List<object> SapRecycle3 { get; set; }
//    public List<object> SapRecycle4 { get; set; }
//}

//public class SapCategorymanager
//{
//    public string SALES_ORGANIZATION { get; set; }
//    public string CATEGORY_MANAGER_ID { get; set; }
//    public string CATEGORY_MANAGER_NAME { get; set; }
//}

//public class SapNutrition
//{
//    public string REGION { get; set; }
//    public List<SapDescriptions> SapDescriptions { get; set; }
//    public double SERVINGSIZE { get; set; }
//    public object SERVINGUNITOFMEASURE { get; set; }
//    public string CALORIES { get; set; }
//    public double TOTALFAT { get; set; }
//    public string TOTALFATPERCENT { get; set; }
//    public double SATURATEDFAT { get; set; }
//    public double TRANSFAT { get; set; }
//    public string SATURATEDTRANSFATPERCENT { get; set; }
//    public double OMEGA6 { get; set; }
//    public double OMEGA3 { get; set; }
//    public double MONOUNSATURATEDFAT { get; set; }
//    public string SUGARALCOHOLS { get; set; }
//    public string CHOLESTEROL { get; set; }
//    public string CHOLESTEROLPERCENT { get; set; }
//    public string SODIUM { get; set; }
//    public string SODIUMPERCENT { get; set; }
//    public string POTASSIUM { get; set; }
//    public string POTASSIUMPERCENT { get; set; }
//    public string TOTALCARBOHYDRATE { get; set; }
//    public string TOTALCARBOHYDRATEPERCENT { get; set; }
//    public string FIBRE { get; set; }
//    public string FIBREPERCENT { get; set; }
//    public string SUGAR { get; set; }
//    public double PROTEIN { get; set; }
//    public string VITAMINAPERCENT { get; set; }
//    public string VITAMINCPERCENT { get; set; }
//    public string CALCIUMPERCENT { get; set; }
//    public string IRONPERCENT { get; set; }
//    public object NONSWEETCLAIMS { get; set; }
//    public object PRODUCTDEVELOPER { get; set; }
//    public object PRODUCTOWNER { get; set; }
//    public object NUTRITIONFLAG { get; set; }
//    public List<object> SapRegionalnutritiondata { get; set; }
//}

//public class SapArticleSubstitution
//{
//    public string SALES_ORGANIZATION { get; set; }
//    public string DETERMINATION_TYPE { get; set; }
//    public string DISTRIBUTION_CHANNEL { get; set; }
//    public object CUSTOMER_GROUP { get; set; }
//    public string SITE_NUMBER { get; set; }
//    public string VALID_FROM { get; set; }
//    public string VALID_TO { get; set; }
//    public string SUBSTITUTE_ARTICLE { get; set; }
//    public string REASON_OF_SUBSTITUTION { get; set; }
//    public string UNITOFMEASURE { get; set; }
//    public string SUBSTITUTIONQUANTITY { get; set; }
//    public string REASON_DESCRIPTION_EN { get; set; }
//    public string REASON_DESCRIPTION_FR { get; set; }
//}

//public class SapArticlehierarchynode
//{
//    public string NODE { get; set; }
//    public string TREE_LEVEL { get; set; }
//    public List<SapDescriptions> SapDescriptions { get; set; }
//}

//public class SapItrade
//{
//    public string REGION { get; set; }
//    public string HSCODE { get; set; }
//    public object CATEGORY { get; set; }
//    public object CATEGORYDESCRIPTION { get; set; }
//    public object LABEL { get; set; }
//    public object GRADE { get; set; }
//    public object SIZE { get; set; }
//    public object PACKAGE { get; set; }
//    public object CONTAINER { get; set; }
//    public object GROWTYPE { get; set; }
//    public object GROWPROCESS { get; set; }
//    public object PRODUCTORIGIN { get; set; }
//}

//public class SapTaxclassification
//{
//    public string SALES_ORGANIZATION { get; set; }
//    public string REGION { get; set; }
//    public object UNIT_OF_MEASURE { get; set; }
//    public string TAXCODE1 { get; set; }
//    public string TAXCODE2 { get; set; }
//    public string TAXCODE3 { get; set; }
//    public string TAXCODE4 { get; set; }
//    public string TAX_CONDITIONAL { get; set; }
//    public string TAX_QUALIFYING { get; set; }
//    public string SWEET_BAKED_GOODS { get; set; }
//    public string OSP_TAXTYPE { get; set; }
//    public object OSP_ADDITIONALFLAG { get; set; }
//    public string VALID_FROM { get; set; }
//    public string VALID_TO { get; set; }
//}

//public class SapSalesset
//{
//    public string SALES_ORGANIZATION { get; set; }
//    public string SALES_SET { get; set; }
//    public string SALES_SET_UNIT_OF_MEASURE { get; set; }
//    public double SALES_SET_QUANTITY { get; set; }
//    public string ARTICLE_CATEGORY { get; set; }
//}

//public class SapAssortment
//{
//    public string ASSORTMENT { get; set; }
//    public string CUSTOMER_VALID_FROM { get; set; }
//    public string CUSTOMER_VALID_TO { get; set; }
//    public string LISTING_VALID_FROM { get; set; }
//    public string LISTING_VALID_TO { get; set; }
//}

//public class SapCustomerAssortment
//{
//    public string REGION { get; set; }
//    public string CUSTOMER_NUMBER { get; set; }
//    public string WAREHOUSE { get; set; }
//    public string LOADING_GROUP { get; set; }
//    public string SHIPPING_POINT { get; set; }
//    public string SALES_OFFICE { get; set; }
//    public string CUSTOMER_GROUP { get; set; }
//    public string SALES_ORGANIZATION { get; set; }
//    public string DISTRIBUTION_CHANNEL { get; set; }
//    public List<SapAssortment> SapAssortments { get; set; }
//}

//public class Root
//{
//    public string ARTICLE_NUMBER { get; set; }
//    public string SALES_ORGANIZATION { get; set; }
//    public SapArticlebasicdata SapArticlebasicdata { get; set; }
//    public List<SapRegionalbasicdata> SapRegionalbasicdata { get; set; }
//    public SapDescriptions SapDescriptions { get; set; }
//    public List<SapUnitofmeasure> SapUnitofmeasure { get; set; }
//    public List<SapPurchasing> SapPurchasing { get; set; }
//    public List<SapSourcing> SapSourcing { get; set; }
//    public List<SapStore> SapStores { get; set; }
//    public List<SapWarehous> SapWarehouses { get; set; }
//    public List<SapSale> SapSales { get; set; }
//    public List<object> SapBillofmaterials { get; set; }
//    public List<SapArticledepartmentgrouping> SapArticledepartmentgrouping { get; set; }
//    public SapNationalrecyclecodes SapNationalrecyclecodes { get; set; }
//    public SapQuebecrecyclecodes SapQuebecrecyclecodes { get; set; }
//    public List<object> SapBottledeposits { get; set; }
//    public List<SapCategorymanager> SapCategorymanager { get; set; }
//    public List<object> SapProvincialtaxes { get; set; }
//    public List<object> SapLiquorcodes { get; set; }
//    public SapNutrition SapNutrition { get; set; }
//    public List<SapArticleSubstitution> SapArticleSubstitution { get; set; }
//    public List<SapArticlehierarchynode> SapArticlehierarchynodes { get; set; }
//    public SapItrade SapItrade { get; set; }
//    public List<object> SapSitegroups { get; set; }
//    public List<SapTaxclassification> SapTaxclassification { get; set; }
//    public List<SapSalesset> SapSalesset { get; set; }
//    public List<SapCustomerAssortment> SapCustomerAssortment { get; set; }
//    public List<object> SapPriceFamilies { get; set; }
//    public string MANUALLYSENT { get; set; }
//    public string SAP_DISPATCH_TS { get; set; }
//}


//    }
//}