using Newtonsoft.Json;
using System.Collections.Generic;

namespace HungryPizza.Domain.Validators;
public class ErrorResponseModel
{
    public string? Message { get; set; }
    public List<string>? Errors { get; set; }

    public string ToJson()
    {
        return JsonConvert.SerializeObject(this);
    }
}