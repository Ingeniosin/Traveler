import {Drawer} from "devextreme-react";
import Menu from "./Menu";

const Layout = ({children, opened}) => {
    return (
        <Drawer
            opened={opened}
            openedStateMode={'shrink'}
            position={'left'}
            revealMode={'slide'}
            component={Menu}
            width={"100%"}
            height={"100vh"}>
            {children}
        </Drawer>
    );
};

export default Layout;
