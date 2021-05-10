using System;

namespace Trianguleiro
{
    class ControladorTriangulo
    {
        // caso ouvesse entrada de dados, este código validaria a regra de negócio:
        // "um lado deve ser menor que a soma dos outros dois lados"
        public bool Validador(Triangulo triangulo) 
        {
            bool valida = false;

            if ((triangulo.posicaoX + triangulo.posicaoY) > triangulo.posicaoZ)
                valida = true;
            else if ((triangulo.posicaoY + triangulo.posicaoZ) > triangulo.posicaoX)
                valida = true;
            else if ((triangulo.posicaoX + triangulo.posicaoZ) > triangulo.posicaoY)
                valida = true;
            if (ValidaLinha(triangulo))
                valida = false;
            return valida;
        }

        public string Tipador(Triangulo triangulo) {

            if (triangulo.posicaoX == triangulo.posicaoY && triangulo.posicaoY == triangulo.posicaoZ)
                return "Equilatero";
            else if (triangulo.posicaoX == triangulo.posicaoY && triangulo.posicaoX != triangulo.posicaoZ)
                return "Isóceles";
            else if (triangulo.posicaoY == triangulo.posicaoZ && triangulo.posicaoY != triangulo.posicaoX)
                return "Isóceles";
            else if (triangulo.posicaoZ == triangulo.posicaoX && triangulo.posicaoZ != triangulo.posicaoY)
                return "Isóceles";
            else
                return "Escaleno";

        }

        private bool ValidaLinha(Triangulo tri)
        {
            if (tri.posicaoX + tri.posicaoY < tri.posicaoZ)
                return true;
            if (tri.posicaoZ + tri.posicaoY < tri.posicaoX)
                return true;
            if (tri.posicaoX + tri.posicaoZ < tri.posicaoY)
                return true;

            return false;
        }
    }
}
