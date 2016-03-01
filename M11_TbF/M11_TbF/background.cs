using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_TbF
{
    class Background
    {
        private static int imagem = 6;

        public int Mudar_para_IMG1()
        {
            imagem = 6;
            if (imagem == 6)
            {
                return 6;
            }
            else
            {
                return 0;
            }
        }

        public int Mudar_para_IMG2()
        {
            imagem = 6;
            if (imagem == 6)
            {
                return 6;
            }
            else
            {
                return 0;
            }
        }

        public void BG_Set(int BG)
        {
            imagem = BG;
        }

        public int BG_Get()
        {
            return imagem;
        }


        }
    }
