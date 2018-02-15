using Alfa.KudosApp.Common.ViewModels;
using Alfa.KudosApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Alfa.KudosApp.WebUI.Api
{
    [RoutePrefix("HomeApi")]
    public class HomeApiController : ApiController
    {
        [Route("RetrieveInitialData")]
        [HttpGet]
        public IHttpActionResult RetrieveInitialData()
        {
            var viewModel = new RewardsViewModel
            {
                Users = DataContainerSingleton.LstUsers,
                Comments = DataContainerSingleton.LstComments
            };

            return Ok(viewModel);
        }
    }
}