import Dashboard from "../components/pages/Dashboard";
import Operadores from "../components/pages/operadores/Operadores";
import Turistas from "../components/pages/turistas/Turistas";


export const routes = [
    {
        id: 1,
        path: '/',
        title: 'Panel de control',
        icon: 'chart',
        component: <Dashboard/>,
    },
    {
        id: 2,
        title: 'Turistas',
        path: '/turistas',
        icon: 'group',
        component: <Turistas/>,
    },
    {
        id: 3,
        title: 'Operadores',
        path: '/operadores',
        icon: 'card',
        component: <Operadores/>,
    }]
  /*  {
        id: 4,
        path: '/configuracion',
        title: 'Configuración',
        icon: 'preferences',
        component: <Dashboard/>,
    },
]*/