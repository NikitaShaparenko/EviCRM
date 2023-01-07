using Microsoft.AspNetCore.Http;

namespace EviCRM.Core.Db.Interfaces
{
    public interface ICurrentUser
    {
        /// <summary>
        /// Флаг, который символизирует, что пользователь является человеком
        /// </summary>
        bool IsAHuman { get; set; }

        /// <summary>
        /// Получить идентификатор текущего пользователя
        /// </summary>
        /// <returns></returns>
        Guid? GetCurrentUserId();
        
        /// <summary>
        /// Задать идентификатор текущего пользователя
        /// </summary>
        /// <param name="userId">Идентификатор </param>
        void SetCurrentUserId(Guid? userId);
        
    }

    public class CurrentUser : ICurrentUser
    {
        private Guid? _userId;
        private readonly IHttpContextAccessor _contextAccessor;
        public bool IsAHuman { get; set; }
        
        public CurrentUser(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public void SetCurrentUserId(Guid? userId)
        {
            _userId = userId;
        }

        public Guid? GetCurrentUserId() => _userId ?? GetCurrentUserId(_contextAccessor.HttpContext);

        public static Guid? GetCurrentUserId(HttpContext httpContext)
        {
            var user = httpContext?.User;

            if (user == null)
                return null;

            var userId = user.Claims.FirstOrDefault(_ => _.Type == "Id")?.Value;

            Guid testGuid = Guid.Empty;
            return testGuid;
        }
    }
}
