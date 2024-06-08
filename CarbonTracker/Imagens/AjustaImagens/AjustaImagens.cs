using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonTracker.Imagens.AjustaImagens
{
    public class AjustaImagens
    {
        public Image RedimensionarImagem(Image imagem, Size novoTamanho)
        {
            Bitmap novaImagem = new Bitmap(novoTamanho.Width, novoTamanho.Height);
            using (Graphics graficos = Graphics.FromImage(novaImagem))
            {
                graficos.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graficos.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graficos.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graficos.DrawImage(imagem, 0, 0, novoTamanho.Width, novoTamanho.Height);
            }
            return novaImagem;
        }

    }
}
