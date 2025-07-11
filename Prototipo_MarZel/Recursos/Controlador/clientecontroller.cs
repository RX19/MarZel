public class clientecontroller
{
    private ClienteDAO dao = new ClienteDAO();

    public model_cliente BuscarCliente(string rtn)
    {
        return dao.BuscarPorRTN(rtn);
    }

    public bool ModificarCliente(model_cliente cliente)
    {
        return dao.ModificarCliente(cliente);
    }
}