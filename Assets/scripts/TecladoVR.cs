using UnityEngine;
using TMPro; // Usamos TextMeshPro que es el estándar de Unity
using UnityEngine.UI;

public class TecladoVR : MonoBehaviour
{
    [Header("Componente de Texto de la Radio")]
    public TMP_InputField inputFieldDestino;

    // Este método lo usaremos para los botones del 0 al 9
    public void PresionarNumero(int numero)
    {
        if (inputFieldDestino != null)
        {
            // Agrega el número al final de lo que ya esté escrito
            inputFieldDestino.text += numero.ToString();
        }
    }

    // Este método lo usaremos para el botón de Borrar (Backspace)
    public void BorrarUltimo()
    {
        if (inputFieldDestino != null && inputFieldDestino.text.Length > 0)
        {
            // Quita el último carácter
            inputFieldDestino.text = inputFieldDestino.text.Substring(0, inputFieldDestino.text.Length - 1);
        }
    }

    // Este método limpia todo el cuadro por si se equivocan
    public void LimpiarTodo()
    {
        if (inputFieldDestino != null)
        {
            inputFieldDestino.text = "";
        }
    }
}