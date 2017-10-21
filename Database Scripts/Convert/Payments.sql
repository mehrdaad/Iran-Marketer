SELECT PAYMENT_ID ,
       RP_TYPE_ID ,
       BRANCH_ID ,
       PAYMENT_DATE ,
     
       INSTRUMENT_ID ,
       APPUSER_ID ,
       FORM_BANK_ACCOUNT_ID ,
       FROM_CASH_ID ,
       FROM_CUSTOMER_ID ,
       FROM_DL_ID ,
       TO_BANK_ACCOUNT_ID ,
       TO_CASH_ID ,
       TO_CUSTOMER_ID ,
       TO_DL_ID ,
       AMOUNT ,
       COMMENTS ,
       VOUCHER_ID ,
       CREATION_DATE ,
       CREATION_TIME ,
       MODIFICATION_DATE ,
       MODIFICATION_TIME ,
       REQUESTER_ID ,
       RP_REASON_TO_ID ,
       PARENT_BRANCH_ID ,
       FROM_SL_ID ,
       TO_SL_ID ,
       RP_STATUS_ID ,
       FROM_REQUESTER_ID ,
       PAYMENT_NUMBER ,
       COUNTER_BRANCH_ID ,
       IS_MANUAL ,
       IS_CANCELED ,
       IS_COMEX ,
       PAYMENT_OGM_ID,RP_REASON_NAME FROM dbo.PAYMENT JOIN dbo.RP_REASON ON RP_REASON.RP_REASON_ID = PAYMENT.RP_REASON_ID WHERE PAYMENT_ID = 19112979

SELECT * FROM dbo.PAY_TO WHERE PAYMENT_ID = 19112979
SELECT * FROM dbo.RP_TYPE
SELECT * FROM dbo.RP_REASON JOIN dbo.SUBSIDIARY_LEDGER ON SUBSIDIARY_LEDGER.SL_ID = RP_REASON.SL_ID
SELECT * FROM dbo.RP_STATUS



