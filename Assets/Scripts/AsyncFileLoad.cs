using System.Threading.Tasks;
using UnityEngine;

namespace New_Folder
{
    public class AsyncFileLoad : MonoBehaviour
    {
        private static async Task LoadText()
        {
            var text = await System.IO.File.ReadAllTextAsync(@"C:\TestText\Test.txt");
            Debug.Log(text);
        }

        private async void Start()
        {
            await LoadText();
        }
    }
}
