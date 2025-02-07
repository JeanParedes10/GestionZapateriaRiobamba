namespace VentasZapatos
{
    public class ListZapatos
    {
        // Lista genérica para almacenar las ventas de todos los días
        private List<VentaDia> ventasSemana;

        // Constructor de ListZapatos
        public ListZapatos()
        {
            ventasSemana = new List<VentaDia>();
        }

        // Método para agregar una venta
        public void AgregarVenta(VentaDia venta)
        {
            ventasSemana.Add(venta);
        }

        // Método para obtener todas las ventas
        public List<VentaDia> ObtenerVentas()
        {
            return ventasSemana;

        }

        // Método para filtrar ventas por marca
        public List<VentaDia> FiltrarVentasPorMarca(string marca)
        {
            switch (marca.ToLower())
            {
                case "Adidas: ":
                    return ventasSemana.FindAll(v => v.Adidas > 0);
                case "Nike: ":
                    return ventasSemana.FindAll(v => v.Nike > 0);
                case "Puma : ":
                    return ventasSemana.FindAll(v => v.Puma > 0);
                default:
                    return ventasSemana;
            }
        }
    }
}