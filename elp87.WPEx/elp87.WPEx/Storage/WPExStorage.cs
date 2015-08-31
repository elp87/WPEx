using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace elp87.WPEx.Storage
{
    public static class WPExStorage
    {
        public static async Task<bool> IsFileExists(this StorageFolder folder, string fileName)
        {
            try { StorageFile file = await folder.GetFileAsync(fileName); }
            catch { return false; }
            return true;
        }
    }
}
