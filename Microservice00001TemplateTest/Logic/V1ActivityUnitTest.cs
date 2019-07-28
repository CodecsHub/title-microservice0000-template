using Autofac.Extras.Moq;
using Microservice00001TemplateAPI.DataAccessLayers;
using Microservice00001TemplateAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Microservice00001TemplateTest.Logic
{
    public class V1ActivityUnitTest
    {
        [Fact]
        //public async Task<List<V1Activity>> GetActivity()
        public async Task GroupReportIsReturnedWithSomeData()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //mock.Mock<IV1ActivityRepositories>()
                //    .Setup(x => x.Getsss<V1Activity>("select * from Activity"))
                //    .ReturnsAsync(GetSamplePeople());
            }
                throw new NotImplementedException();
        }


        private List<V1Activity> GetSamplePeople()
        {
            List<V1Activity> output = new List<V1Activity>
            {
                new V1Activity
                {
                    AudAuditIditId = 1,
                    SystemName = "Tim",
                    ActionName = "Tim",
                    UserName = "Tim",
                    Remarks = "Corey",
                    DateCreated = DateTime.Now
                },
                new V1Activity
                {
                    AudAuditIditId = 1,
                    SystemName = "Tim",
                    ActionName = "Tim",
                    UserName = "Tim",
                    Remarks = "Corey",
                    DateCreated = DateTime.Now
                },
                new V1Activity
                {
                    AudAuditIditId = 1,
                    SystemName = "Tim",
                    ActionName = "Tim",
                    UserName = "Tim",
                    Remarks = "Corey",
                    DateCreated = DateTime.Now
                },
                new V1Activity
                {
                    AudAuditIditId = 1,
                    SystemName = "Tim",
                    ActionName = "Tim",
                    UserName = "Tim",
                    Remarks = "Corey",
                    DateCreated = DateTime.Now
                }
            };

            return output;
        }
    }
}
