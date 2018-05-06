using System;
using Newtonsoft.Json;

namespace Trakr.Libs.TheMovieDb.Model.ApiResponse
{
    
    public class ApiError
    {
        private int _statusCode;

        [JsonProperty("status_code" )]
        public int StatusCode
        {
            get { return _statusCode; }
            private set
            {
                _statusCode = value;

                TmdbStatusCode = Enum.IsDefined( typeof( TmdbStatusCode ), _statusCode )
                    ? ( TmdbStatusCode )_statusCode
                    : TmdbStatusCode.Unknown;
            }
        }

        [JsonProperty("status_message" )]
        public string Message { get; private set; }

        public TmdbStatusCode TmdbStatusCode { get; private set; }

        public override string ToString()
            => $"Status: {StatusCode}: {Message}";
    }
}
