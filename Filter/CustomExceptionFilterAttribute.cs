using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;

namespace SimpleKonwWebDevelope.Filter
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private ILogger<CustomExceptionFilterAttribute> _logger;
        private IModelMetadataProvider _modelMetadataProvider;

        public CustomExceptionFilterAttribute(ILogger<CustomExceptionFilterAttribute> logger,
            IModelMetadataProvider modelMetadataProvider)
        {
            _logger = logger;
            _modelMetadataProvider = modelMetadataProvider;
        }

        public override void OnException(ExceptionContext context)
        {
            _logger.LogError($"响应{context.HttpContext.Request.Path}时出现异常，异常信息{context.Exception.Message}");
            if (!context.ExceptionHandled)
            {
                if (!IsAjaxRequest(context.HttpContext.Request))
                {
                    context.Result = new JsonResult(new
                    {
                        Result = false,
                        Msg = "请求发生错误",
                        DebugMsg = context.Exception.Message
                    });
                }
                else
                {
                    var result = new ViewResult { ViewName = "~/Views/Shared/Error.cshtml" };
                    result.ViewData = new ViewDataDictionary(_modelMetadataProvider, context.ModelState);
                    result.ViewData.Add("Exception",context.Exception.Message);
                    context.Result = result;
                }
            }
            context.ExceptionHandled = true;//异常已处理
        }

        private bool IsAjaxRequest(HttpRequest request)
        {
            string header = request.Headers["X-Requested-With"];
            return "XMLHttpRequest".Equals(header);

        }
    }
}
