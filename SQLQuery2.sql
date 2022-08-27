



/*==============================================================*/
/* Table: AGENCY                                                */
/*==============================================================*/
create table AGENCY (
   AGENCY_ID            int           IDENTITY(1,1)       not null,
   AGENCY_NAME          varchar(255)         not null,
   AGENCY_ADDRESS       varchar(255)         not null,
   AGENCY_TELEPHONE     varchar(255)         not null,
   AGENCY_FAX           varchar(255)         null,
   constraint PK_AGENCY primary key nonclustered (AGENCY_ID)
);


/*==============================================================*/
/* Table: BRAND                                                 */
/*==============================================================*/
create table BRAND (
   CAR_BRAND_ID         int        IDENTITY(1,1)          not null ,
   CAR_BRAND_NAME       varchar(255)         not null,
   CAR_BRAND_COUNTRY    varchar(255)         not null,
   constraint PK_BRAND primary key nonclustered (CAR_BRAND_ID)
);

/*==============================================================*/
/* Table: CAR                                                   */
/*==============================================================*/
create table CAR (
   CAR_ID               int      IDENTITY(1,1)            not null,
   CUSTOMER_ID          int                  null,
   CAR_NAME             varchar(255)         not null,
   CAR_YEAR             int                  not null,
   constraint PK_CAR primary key nonclustered (CAR_ID)
);

/*==============================================================*/
/* Index: BUY_FK                                                */
/*==============================================================*/
create index BUY_FK on CAR (
CUSTOMER_ID
);


/*==============================================================*/
/* Table: CONTRACT                                              */
/*==============================================================*/
create table CONTRACT (
   AGENCY_ID            int        IDENTITY(1,1)          not null,
   CAR_BRAND_ID         int                  not null,
   CONTRACT_ID          int                  not null,
   DESCRIPTION          varchar(1024)        null
);


/*==============================================================*/
/* Index: HASCONTRACT_FK                                        */
/*==============================================================*/
create index HASCONTRACT_FK on CONTRACT (
CAR_BRAND_ID
);


/*==============================================================*/
/* Index: MAKECONTRACT_FK                                       */
/*==============================================================*/
create index MAKECONTRACT_FK on CONTRACT (
AGENCY_ID
);


/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   CUSTOMER_ID          int        IDENTITY(1,1)          not null,
   CUSTOMER_NAME        varchar(255)         not null,
   CUSTOMER_MOBILE      varchar(255)         not null,
   CUSTOMER_TELEPHONE   varchar(255)         null,
   CUSTOMER_ADDRESS     varchar(255)         not null,
   constraint PK_CUSTOMER primary key nonclustered (CUSTOMER_ID)
);


/*==============================================================*/
/* Table: DEALWITH                                              */
/*==============================================================*/
create table DEALWITH (
   AGENCY_ID            int                  not null,
   SHIPPER_ID           int                  not null,
   constraint PK_DEALWITH primary key (AGENCY_ID, SHIPPER_ID)
);


/*==============================================================*/
/* Index: SHIPTO_FK                                             */
/*==============================================================*/
create index SHIPTO_FK on DEALWITH (
AGENCY_ID
);


/*==============================================================*/
/* Index: DEALWITH_FK                                           */
/*==============================================================*/
create index DEALWITH_FK on DEALWITH (
SHIPPER_ID
);


/*==============================================================*/
/* Table: HAS                                                   */
/*==============================================================*/
create table HAS (
   CAR_ID               int                  not null,
   CAR_BRAND_ID         int                  not null,
   constraint PK_HAS primary key (CAR_ID, CAR_BRAND_ID)
);


/*==============================================================*/
/* Index: BRANDSCARS_FK                                         */
/*==============================================================*/
create index BRANDSCARS_FK on HAS (
CAR_ID
);


/*==============================================================*/
/* Index: CARBRANDS_FK                                          */
/*==============================================================*/
create index CARBRANDS_FK on HAS (
CAR_BRAND_ID
);


/*==============================================================*/
/* Table: SHIPPER                                               */
/*==============================================================*/
create table SHIPPER (
   SHIPPER_ID           int       IDENTITY(1,1)           not null,
   SHIPPER_NAME         varchar(255)         not null,
   SHIPPER_ADDRESS      varchar(255)         not null,
   SHIPPER_TELEPHONE    varchar(255)         not null,
   SHIPPER_COUNTRY      varchar(255)         not null,
   constraint PK_SHIPPER primary key nonclustered (SHIPPER_ID)
);


/*==============================================================*/
/* Table: SOLD_CUSTOMER_CAR                                     */
/*==============================================================*/
create table SOLD_CUSTOMER_CAR (
   CAR_ID               int                  not null,
   AGENCY_ID            int                  not null,
   CUSTOMER_ID          int                  not null,
   CUS_CUSTOMER_ID      int                  null,
   CAR_NAME             varchar(255)         not null,
   CAR_YEAR             int                  not null,
   PRICE                float                not null,
   constraint PK_SOLD_CUSTOMER_CAR primary key (CAR_ID)
);

/*==============================================================*/
/* Index: SELL_FK                                               */
/*==============================================================*/
create index SELL_FK on SOLD_CUSTOMER_CAR (
CUSTOMER_ID
);


/*==============================================================*/
/* Index: BUY_USEDCAR_FK                                        */
/*==============================================================*/
create index BUY_USEDCAR_FK on SOLD_CUSTOMER_CAR (
AGENCY_ID
);


alter table CAR
   add constraint FK_CAR_BUY_CUSTOMER foreign key (CUSTOMER_ID)
      references CUSTOMER (CUSTOMER_ID);


alter table CONTRACT
   add constraint FK_CONTRACT_HASCONTRA_BRAND foreign key (CAR_BRAND_ID)
      references BRAND (CAR_BRAND_ID);


alter table CONTRACT
   add constraint FK_CONTRACT_MAKECONTR_AGENCY foreign key (AGENCY_ID)
      references AGENCY (AGENCY_ID);


alter table DEALWITH
   add constraint FK_DEALWITH_DEALWITH_SHIPPER foreign key (SHIPPER_ID)
      references SHIPPER (SHIPPER_ID);


alter table DEALWITH
   add constraint FK_DEALWITH_SHIPTO_AGENCY foreign key (AGENCY_ID)
      references AGENCY (AGENCY_ID);


alter table HAS
   add constraint FK_HAS_BRANDSCAR_CAR foreign key (CAR_ID)
      references CAR (CAR_ID);


alter table HAS
   add constraint FK_HAS_CARBRANDS_BRAND foreign key (CAR_BRAND_ID)
      references BRAND (CAR_BRAND_ID);


alter table SOLD_CUSTOMER_CAR
   add constraint FK_SOLD_CUS_BUY_USEDC_AGENCY foreign key (AGENCY_ID)
      references AGENCY (AGENCY_ID);


alter table SOLD_CUSTOMER_CAR
   add constraint FK_SOLD_CUS_CAR_SOLD_CAR foreign key (CAR_ID)
      references CAR (CAR_ID);


alter table SOLD_CUSTOMER_CAR
   add constraint FK_SOLD_CUS_SELL_CUSTOMER foreign key (CUSTOMER_ID)
      references CUSTOMER (CUSTOMER_ID);