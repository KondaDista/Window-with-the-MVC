public abstract class ControllerWindow
{
    protected ModelWindow _modelWindow;
    protected ViewWindow _viewWindow;

    protected ControllerWindow(ModelWindow model, ViewWindow view)
    {
        _modelWindow = model;
        _viewWindow = view;
    }

    protected abstract void ShowWindow();

}
