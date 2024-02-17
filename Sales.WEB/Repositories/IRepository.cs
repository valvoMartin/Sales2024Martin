namespace Sales.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);

        /// <summary>
        /// Post que no devuelve nada
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<HttpResponseWrapper<object>> Post<T>(string url, T model);

        /// <summary>
        /// Post que devuelve algo, devuelve el TResponse que es la respuesta Http
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="url"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model);
    }

}
