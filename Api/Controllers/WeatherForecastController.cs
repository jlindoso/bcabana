namespace Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using business.Model.Classes;
using business.Model.Services;
using business.Model.Interfaces;
using business.Model.DTO;

[ApiController]
[Route("v1/[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
   
    public WeatherForecastController(){
        
    }

    
}
