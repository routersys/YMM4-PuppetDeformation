using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppetDeformation
{
    internal class ShaderResourceUri
    {
        public static Uri Get(string shaderName) => new($"pack://application:,,,/PuppetDeformation;component/Resources/Shader/{shaderName}.cso");
    }
}
