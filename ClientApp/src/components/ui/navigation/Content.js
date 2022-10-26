import AppRouter from "../../../routers/AppRouter";
import {ScrollView} from "devextreme-react";

const Content = () => {
    return (
        <ScrollView className="content h-100 p-5">
            <div className="container-sm p-3">
                <AppRouter/>
            </div>
        </ScrollView>
    );
};

export default Content;
