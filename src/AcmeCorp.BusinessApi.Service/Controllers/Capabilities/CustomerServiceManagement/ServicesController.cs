﻿using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement;
using AcmeCorp.BusinessApi.Libraries.Controllers.Capabilities.CustomerServiceManagement;

namespace AcmeCorp.BusinessApi.Service.Controllers.Capabilities.CustomerServiceManagement
{
    /// <inheritdoc />
    public class ServicesController : CustomerEndUsersControllerBase
    {
        /// <inheritdoc />
        public ServicesController(ICustomerServiceManagementCapability capability) : base(capability)
        {
        }
    }
}
