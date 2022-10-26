import {Route, Routes} from "react-router-dom";
import {routes} from "../configuration/Configuration";

const AppRouter = () => {
    return (
        <Routes>
            {
                routes.map((route, index) => <Route key={index} path={route.path} element={route.component}/>)
            }
        </Routes>
    );
};

export default AppRouter;
