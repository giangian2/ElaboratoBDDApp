create table Customer (
     iden_card_numb varchar(50) not null,
     name varchar(20) null,
     surname varchar(20) null,
     birth_date date null,
     address varchar(50) null,
     P_IVA varchar(20) not null,
     final_client varchar(50) null,
     PRIMARY KEY (iden_card_numb));

create table Document (
     name varchar(50) not null,
     size int null,
     path varchar(50) not null,
     type varchar(20) not null,
     model_iden_card_numb varchar(50) not null,
     primary key (name));

create table Event (
     codOffer int not null,
     offer_date date not null,
     codEvent int not null identity(1,1),
     start_time datetime not null,
     end_time datetime not null,
     model_iden_card_numb varchar(50) not null,
     transport_ID int not null,
     primary key (codEvent,offer_date,codOffer));

create table Location (
     ID int not null identity(1,1),
     CAP varchar(10) not null,
     Avenue varchar(20) not null,
     City varchar(20) not null,
     Number int not null,
     Country varchar(20) not null,
     primary key (ID));

create table Manager (
     iden_card_numb varchar(50) not null,
     name varchar(20) null,
     surname varchar(20) null,
     birth_date date null,
     address varchar(50) null,
     primary key (iden_card_numb));

create table Model (
     iden_card_numb varchar(50) not null,
     name varchar(20) null,
     surname varchar(20) null,
     birth_date date null,
     address varchar(50) null,
     eyes_color varchar(20) null,
     age int null,
     email varchar(50) null,
     hair_color varchar(20) null,
     shoes_number int null,
     height decimal(3,2) null,
     waist decimal(3,1) null,
	 success_rate decimal(3,2) null,
     manager_iden_card_numb varchar(50) not null,
     primary key (iden_card_numb));

create table Offer (
     approval_date date null,
     codOffer int not null identity(1,1),
     date_ date not null,
     status varchar(10) not null,
     requested_models int not null,
     short_description varchar(100) null,
     long_description varchar(100) null,
     budget int null,
     offer_type_name varchar(20) not null,
     location_ID int not null,
     customer_iden_card_numb varchar(50) not null,
     primary key (codOffer, date_));

create table OfferType (
     name varchar(20) not null,
     description varchar(100) not null,
     primary key (name));

create table Photo (
     name varchar(50) not null,
     size int null,
     path varchar(50) not null,
     model_iden_card_numb varchar(50) not null,
     primary key (name));

create table proposal (
     ID int not null identity(1,1),
     model_iden_card_numb varchar(50) not null,
     codOffer int not null,
     offer_date date not null,
     status char(1) not null,
     primary key (ID));

create table Social (
     model_iden_card_numb varchar(50) not null,
     platform varchar(20) not null,
     link varchar(100) not null,
     username varchar(20) not null,
     followers int null,
     primary key (model_iden_card_numb, platform));

create table Transport (
     ID int not null identity(1,1),
     type varchar(20) not null,
     description varchar(100) not null,
     start_datetime datetime not null,
     arrival_datetime datetime null,
     departure_place varchar(50) not null,
     destination_place varchar(50) null,
     primary key (ID));

create table Video (
     name varchar(50) not null,
     size int null,
     path varchar(50) not null,
     model_iden_card_numb varchar(50) not null,
     primary key (name));


-- Constraints Section
-- ___________________ 

alter table Document add
     foreign key (model_iden_card_numb)
     references Model(iden_card_numb);

alter table Event add constraint FKparticipate_FK
     foreign key (model_iden_card_numb)
     references Model(iden_card_numb);

alter table Event add constraint FKneed_FK
     foreign key (transport_ID)
     references Transport(ID);

alter table Event add constraint FKevent_offer
     foreign key (codOffer, offer_date)
     references Offer(codOffer, date_);

alter table Model add constraint FKPer_Mod_FK
     foreign key (manager_iden_card_numb)
     references Manager(iden_card_numb);

alter table Offer add constraint FKOOT_FK
     foreign key (offer_type_name)
     references OfferType(name);

alter table Offer add constraint FKOL_FK
     foreign key (location_ID)
     references Location(ID);

alter table Offer add constraint FKmake_FK
     foreign key (customer_iden_card_numb)
     references Customer(iden_card_numb);

alter table Photo add
     foreign key (model_iden_card_numb)
     references Model(iden_card_numb);

alter table proposal add constraint FKpro_Off
     foreign key (codOffer, offer_date)
     references Offer(codOffer, date_);

alter table proposal add constraint FKpro_Mod_FK
     foreign key (model_iden_card_numb)
     references Model(iden_card_numb);

alter table Social add constraint FKModelSocial
     foreign key (model_iden_card_numb)
     references Model(iden_card_numb);

alter table Video add
     foreign key (model_iden_card_numb)
     references Model(iden_card_numb);


-- Index Section
-- _____________ 

create unique index FKPer_Cus_IND
     on Customer (iden_card_numb);

create unique index FKMed_Doc_IND
     on Document (name);

create unique index ID_Event_IND
     on Event (model_iden_card_numb, offer_date);

create index FKparticipate_IND
     on Event (model_iden_card_numb);

create unique index ID_Location_IND
     on Location (ID);

create unique index FKPer_Man_IND
     on Manager (iden_card_numb);

create unique index FKPer_Mod_IND
     on Model (iden_card_numb);

create index FKmanages_IND
     on Model (iden_card_numb);
     
create unique index UNI_mail
     on Model (email);

create unique index ID_Offer_IND
     on Offer (codOffer, date_);

create index FKOOT_IND
     on Offer (offer_type_name);

create index FKOL_IND
     on Offer (location_ID);

create index FKmake_IND
     on Offer (customer_iden_card_numb);

create unique index ID_OfferType_IND
     on OfferType (name);

create unique index FKMed_Pho_IND
     on Photo (name);

create unique index ID_proposal_IND
     on proposal (codOffer, offer_date, model_iden_card_numb);

create unique index ID_Proposal_UNIQUE
     on proposal (model_iden_card_numb, offer_date);

create index FKpro_Mod_IND
     on proposal (ID);

create unique index ID_Social_IND
     on Social (model_iden_card_numb, platform);

create unique index ID_Transport_IND
     on Transport (ID);

create unique index FKMed_Vid_IND
     on Video (name);