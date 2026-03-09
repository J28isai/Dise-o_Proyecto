using Diseño_Proyecto.Model;
using Diseño_Proyecto.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Diseño_Proyecto.ViewModel
{
    public partial class MenuViewModel : ObservableObject
    {
        private readonly IMenuRepo _menuRepo;

        [ObservableProperty]
        private object? currentViewModel;
        [ObservableProperty]
        private MenuOp? sel;


        public ObservableCollection<MenuOp> MenuOptions { get; } = new();

        public MenuViewModel(IMenuRepo menuRepo)
        {
            _menuRepo = menuRepo;

            foreach (var option in _menuRepo.GetMenuOptions())
                MenuOptions.Add(option);

        }
        [RelayCommand]
        private void Navigate(MenuOp? option)
        {
            if (option is null) return;

            CurrentViewModel = option.route switch
            {
                "Inicio" => new InicioViewModel(),
                "Inventario" => new InventarioViewModel(),
                "Ventas" => new VentasViewModel(),
            };
        }
    }
}

