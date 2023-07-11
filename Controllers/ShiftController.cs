//using Microsoft.AspNetCore.Mvc;
//using WebApplication2.Domain.Repositories.Abstract;
//using System;
//using WebApplication2.Domain.Repositories.EntityFramework;

//public class ShiftController : Controller
//{
//    private readonly IShiftEnRepository shiftEnRepository;

//    public ShiftController(IShiftEnRepository shiftEnRepository)
//    {
//        this.shiftEnRepository = shiftEnRepository;
//    }

//    //выбираем все записи из БД и передаем их в представление
//    public IActionResult Index()
//    {
//        var model = shiftEnRepository.GetShiftEn();
//        return View(model);
//    }


//}