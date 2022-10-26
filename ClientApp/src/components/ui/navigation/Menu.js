import {Button, ScrollView, TreeView} from "devextreme-react";
import logo from '../../../assets/logo_dark.svg'
import user from '../../../assets/user.svg'
import {useLocation, useNavigate} from "react-router-dom";
import {routes} from "../../../configuration/Configuration";

const Menu = () => {
    return (
        <ScrollView className="p-0 m-0 w-100 menu">
            <MenuHeader/>
            <MenuBody/>
            <MenuFooter/>
        </ScrollView>
    );
};

const MenuHeader = () => {
    return (
        <>
            <hr/>
            <div className=" d-flex flex-column justify-content-center align-items-center mb-2 text-center headerDetails">
                <img src={user} alt="users" className="menu-logo rounded-circle w-50"/>
                <p className="m-0"><strong>Bienvenido</strong>,  Juan Campiño</p>
                <p className="m-0"><strong>Ultimo acceso: </strong>2022/10/26 9:46 pa</p>
                <p className="m-0"><strong>Rol: </strong>Administrador</p>
                <Button className="position-absolute end-0 top-0 m-3 mt-4" icon={"remove"} stylingMode={'text'} hint="Cerrar sesión"/>
            </div>
            <hr/>
        </>
    );
};

const MenuBody = () => {
    const location = useLocation();
    const navigate = useNavigate();
    return (
        <>
            <h6 className="text-center fw-bold p-0 m-0">Menu principal</h6>
            <div style={{minHeight: 'calc(100vh - 430px)',}}>
                <TreeView
                    defaultItems={
                        routes.map(({id, parent, title, path, icon}) => ({
                            id, parent, title, icon, path,
                            expanded: location.pathname.includes(path),
                            selected: location.pathname.includes(path)
                        }))
                 }
                    width={"100%"}
                    elementAttr={{class: "mt-3 mx-2"}}
                    animationEnabled={true}
                    selectionMode={'single'}
                    dataStructure={'plain'}
                    parentIdExpr={'parent'}
                    displayExpr={'title'}
                    keyExpr={'id'}
                    expandedExpr={'expanded'}
                    searchMode={'contains'}
                    searchEditorOptions={{name: 'Buscar',}}
                    onItemClick={async e => {
                        const url = e?.node?.itemData?.path;
                        if(url) {
                            navigate(url);
                            e.component.selectItem(e.node.itemData.id);
                        } else {
                            if(e.node.expanded) {
                                await e.component.collapseItem(e.node.itemData.id);
                            } else  {
                                await e.component.expandItem(e.node.itemData.id);
                            }
                        }
                    }}
                />
            </div>
        </>
    );
};

const MenuFooter = () => {
    return (
        <>
            <hr/>
            <div className="d-flex flex-column justify-content-center align-items-center gap-1">
                <img src={logo} alt="logo" className="menu-logo" style={{cursor: 'pointer'}}/>
                <p className="text-center faq">©2022 Todos los derechos reservados.</p>
            </div>
        </>
    );
};

export default Menu;
