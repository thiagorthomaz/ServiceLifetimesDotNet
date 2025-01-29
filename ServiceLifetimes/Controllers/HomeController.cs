using Microsoft.AspNetCore.Mvc;
using ServiceLifetimes.Models;
using ServiceLifetimes.Services;
using System.Diagnostics;

namespace ServiceLifetimes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IScopedService scopedFirstService;
        private readonly IScopedService scopedSecondService;

        private readonly ISingletonService singletonFirstService;
        private readonly ISingletonService singletonSecondService;

        private readonly ITransientService transcientFirstService;
        private readonly ITransientService transcientSecondService;



        public HomeController(ILogger<HomeController> logger, 
            IScopedService _scopedFirstService,
            IScopedService _scopedSecondService,
            ISingletonService _singletonFirstService,
            ISingletonService _singletonSecondService,
            ITransientService _transcientFirstService,
            ITransientService _transcientSecondService)
        {
            _logger = logger;

            scopedFirstService = _scopedFirstService;
            scopedSecondService = _scopedSecondService;

            singletonFirstService = _singletonFirstService;
            singletonSecondService = _singletonSecondService;

            transcientFirstService = _transcientFirstService;
            transcientSecondService = _transcientSecondService;
        }

        public IActionResult Index()
        {
            OperationDTO operationDTO = new OperationDTO();
            operationDTO.scopedFirstId = scopedFirstService.GetOperationId();
            operationDTO.scopedSecondId = scopedSecondService.GetOperationId();

            operationDTO.singletonFirstId = singletonFirstService.GetOperationId();
            operationDTO.singletonSecondId = singletonSecondService.GetOperationId();
            
            operationDTO.transcientFirstId = transcientFirstService.GetOperationId();
            operationDTO.transcientSecondId = transcientSecondService.GetOperationId();

            return View(operationDTO);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
