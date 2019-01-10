using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="Nome Obrigadtorio")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 10, ErrorMessage = "Campo deve conter entre 10 e 50 Caracteres")]
        public string Observacao { get; set; }

        [Required(ErrorMessage = "Idade Obrigadtoria")]
        [Range(18, 70, ErrorMessage = "Idade deve ser entre 18 e 70 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Email Obrigadtorio")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage ="Email Invalido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Login Obrigadtorio")]
        [RegularExpression(@"[a-zA-z]{5,15}", ErrorMessage ="Login Invalido")]    
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Login ja existente")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha obrigatoria")]        
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "Senhas não conferem")]
        public string ConfirmarSenha { get; set; }

    }
}