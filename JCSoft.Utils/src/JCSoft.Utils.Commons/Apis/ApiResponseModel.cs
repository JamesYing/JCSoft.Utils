namespace JCSoft.Utils.Commons.Apis
{
    public class ApiResponseModel
    {
        public bool IsError { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorReason { get; set; }
    }

    public class ApiResponseModel<TEntity> : ApiResponseModel
    {
        public ApiResponseModel()
        {

        }

        public ApiResponseModel(TEntity data)
        {
            Data = data;
        }
        public TEntity Data { get; set; }
    }

    public class ApiPagedResponseModel<TEntity> : ApiResponseModel<PagedResponse<TEntity>>
    {

    }
}