import './assets/design/dx.material.custom-scheme.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import './assets/design/global.css'
import Layout from "./components/ui/navigation/Layout";
import {useState} from "react";
import Content from "./components/ui/navigation/Content";

const App = () => {
    const [opened, setOpened] = useState(true);
    return (
        <div className="m-0 p-0 h-100 position-absolute top-0 start-0 container-fluid bg">
            <Layout opened={opened}>
                <Content/>
            </Layout>
        </div>
    );
};

export default App;
