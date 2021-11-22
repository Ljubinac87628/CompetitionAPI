using Competition.BusinessLogic.Interfaces;
using Competition.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition.BusinessLogic
{
    public class CompetitorBusinessLogic : ICompetitorBusinessLogic
    {
        private readonly ICompetitorService _competitorService;

        public CompetitorBusinessLogic(ICompetitorService competitorService)
        {
            _competitorService = competitorService;
        }
        public string Test()
        {
            return _competitorService.Test();
        }
    }
}
