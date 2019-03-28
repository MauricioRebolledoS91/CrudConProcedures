using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crudStoreProcedure.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "El nombre de usuario no puede estar en blanco")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Por favor ingresa una descripción de produco entre 10 y 200 carácteres de longitud")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Por favor ingrese un nombre de usuario que empiece con letra mayúscula")]  //el campo solo debe tener letras y espacios y comenzar con una letra mayúsucla
        public string UserFirstName { get; set; }
        [Required(ErrorMessage = "El apellido no puede estar en blanco")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Por favor ingresa una descripción de produco entre 10 y 200 carácteres de longitud")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Por favor ingrese un apellido que empiece con letra mayúscula")]  //el campo solo debe tener letras y espacios y comenzar con una letra mayúsucla
        public string UserLastName { get; set; }
    }
}