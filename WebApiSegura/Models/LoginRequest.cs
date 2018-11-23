namespace WebApiSegura.Models
{
    /// <summary>
    /// Clase donde recibiremos las credenciales del usuario.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Obtiene o establese el nombre del usuario
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Obtiene o establese la contraseña del usuario
        /// </summary>
        public string Password { get; set; }
    }
}