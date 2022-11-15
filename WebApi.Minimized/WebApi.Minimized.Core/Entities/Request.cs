using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Request
    {
        public Request()
        {
            Doc = new HashSet<Doc>();
            InverseParent = new HashSet<Request>();
            ReqInfo = new HashSet<ReqInfo>();
            ReqPassport = new HashSet<ReqPassport>();
        }

        public decimal RequestId { get; set; }
        public decimal? ManagerId { get; set; }
        public decimal? SupplierId { get; set; }
        public int RequestType { get; set; }
        public int RequestStatus { get; set; }
        public int RequestOrigin { get; set; }
        public bool RequestBooking { get; set; }
        public decimal? RequestTotalCost { get; set; }
        public decimal? RequestNetCost { get; set; }
        public string RequestCurrency { get; set; }
        public string RequestContactNameOld { get; set; }
        public string RequestContactCompany { get; set; }
        public string RequestContactPhone { get; set; }
        public string RequestContactPhone2 { get; set; }
        public string RequestContactEmail { get; set; }
        public string RequestDestination { get; set; }
        public DateTime? RequestFromDate { get; set; }
        public DateTime? RequestToDate { get; set; }
        public string RequestNote { get; set; }
        public DateTime RequestUpdated { get; set; }
        public DateTime RequestAdded { get; set; }
        public decimal? ContactId { get; set; }
        public decimal? ContactInfoId { get; set; }
        public bool RequestArchived { get; set; }
        public string RequestSupplierRefNo { get; set; }
        public string RequestSupplierAccNo { get; set; }
        public decimal? RequestSupplierAccAmount { get; set; }
        public DateTime? RequestSupplierAccDate { get; set; }
        public DateTime? RequestSupplierPayTill { get; set; }
        public string RequestRefNo { get; set; }
        public string RequestAccNo { get; set; }
        public decimal? RequestAccAmount { get; set; }
        public decimal? RequestAccServiceFee { get; set; }
        public string RequestService { get; set; }
        public string RequestHotel { get; set; }
        public string RequestCalculation { get; set; }
        public decimal? RequestDiscount { get; set; }
        public decimal? RequestExchangeRate { get; set; }
        public decimal? RequestCommission { get; set; }
        public DateTime? RequestCommissionPaid { get; set; }
        public string RequestCommissionCurrency { get; set; }
        public string RequestContactFirstName { get; set; }
        public string RequestContactMiddleName { get; set; }
        public string RequestContactLastName { get; set; }
        public string RequestContactPhoneNote { get; set; }
        public string RequestContactPhone2Note { get; set; }
        public string RequestContactPhone3 { get; set; }
        public string RequestContactPhone3Note { get; set; }
        public string RequestContactAddress { get; set; }
        public string RequestCountry { get; set; }
        public Guid RequestGuid { get; set; }
        public decimal? AddedById { get; set; }
        public string RequestDestinationOld { get; set; }
        public decimal? AgencyId { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? RequestPayTill { get; set; }
        public DateTime? RequestPaid { get; set; }
        public string RequestFlight { get; set; }
        public decimal? RequestPrepaid { get; set; }
        public DateTime? RequestPrepaidPayTill { get; set; }
        public DateTime? RequestPrepaidPaid { get; set; }
        public DateTime? RequestAccDate { get; set; }
        public DateTime? RequestSupplierPaid { get; set; }
        public string RequestIpaddress { get; set; }
        public bool RequestOnAccount { get; set; }
        public string RequestPaidBank { get; set; }
        public string RequestBoardBasis { get; set; }
        public string RequestRoomType { get; set; }
        public DateTime? RequestDocReceived { get; set; }
        public string RequestTransfer { get; set; }
        public string RequestDocSentBy { get; set; }
        public DateTime? RequestDocSent { get; set; }
        public string RequestDocReceivedBy { get; set; }
        public decimal? ParentId { get; set; }
        public string RequestVisa { get; set; }
        public string RequestContactEmail2 { get; set; }
        public decimal? RequestCommissionSignedById { get; set; }
        public string RequestFromCountry { get; set; }
        public string RequestFromCity { get; set; }
        public decimal? RequestUpdatedById { get; set; }
        public decimal? RequestCommissionManager1Amount { get; set; }
        public decimal? RequestCommissionManager1Percent { get; set; }
        public decimal? RequestCommissionManager2Amount { get; set; }
        public decimal? RequestCommissionManager2Percent { get; set; }
        public decimal? ManagerId2 { get; set; }
        public decimal? RequestSupplierCatalogPrice { get; set; }
        public string RequestSupplierNettoCur { get; set; }
        public string RequestContactCompanyEdrpou { get; set; }
        public string RequestInsurer { get; set; }
        public string RequestSpecialNote { get; set; }
        public DateTime? RequestRequestedFeedback { get; set; }

        public virtual Person AddedBy { get; set; }
        public virtual Company Agency { get; set; }
        public virtual Person Manager { get; set; }
        public virtual Request Parent { get; set; }
        public virtual Company Supplier { get; set; }
        public virtual ICollection<Doc> Doc { get; set; }
        public virtual ICollection<Request> InverseParent { get; set; }
        public virtual ICollection<ReqInfo> ReqInfo { get; set; }
        public virtual ICollection<ReqPassport> ReqPassport { get; set; }
    }
}
