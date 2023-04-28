using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestProject_Practice2V2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    [BindProperty]
    public Form Data {get;set;} // va a tener una propiedad que se llama data.
    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var parametro = Request.Query["Id"];

        //buscar en la base de datos el formulario con id que esta en el parametro.
        //var formulario - servicioformulario.get(parametro)


     Data = new Form(); // crando el objeto.
     Data.Mail = parametro;
     Data.Password = "12345";
    
    }

    public IActionResult OnPost(){
        if(!ModelState.IsValid){ // si esto no es valido
            return Page();
        }
        //guardar en la base de datos / Procesar la información.
        var formValues = Data;
        
        return RedirectToAction("Index");

    }
}

