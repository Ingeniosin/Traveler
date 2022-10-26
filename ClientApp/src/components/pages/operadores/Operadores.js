import useFetchOperadorsIds from "../../../hooks/useFetchOperadorsIds";
import LoadingSpinner from "../../../dynamic/devextreme/LoadingSpinner";
import OperadorItem from "./OperadorItem";
import {Button, Popup} from "devextreme-react";
import {useState} from "react";
import FormOperador from "./form/FormOperador";

const Operadores = () => {
    const {isLoading, isError, data, refetch} = useFetchOperadorsIds();
    const [visiblePopup, setVisiblePopup] = useState(false);
    if(isError) return null;



    return (
        <>
            <h2>Operadores registrados</h2>
            <div className="mt-lg-3 bg-white rounded-5 shadow-lg p-lg-5 container position-relative">

                {
                    isLoading ? <LoadingSpinner/> :(<>

                        <Button className="position-absolute end-0 top-0 m-3 shadow-lg"  icon="plus" type="default" text="Añadir" onClick={() => setVisiblePopup(true)}></Button>

                        <Popup title={"Crear un operador"} height={"auto"} width={"850px"} showTitle={true} visible={visiblePopup} resizeEnabled={true} showCloseButton={true} deferRendering={true} onHiding={() => setVisiblePopup(false)} closeOnOutsideClick={true}>
                            <div className="p-2">
                                <FormOperador onSave={() => {
                                    setVisiblePopup(false);
                                    refetch();
                                }}/>
                            </div>
                        </Popup>

                        <div className="row px-lg-5 gap-3">
                            {
                                data.map(x => {
                                    return <OperadorItem id={x}/>
                                })
                            }
                        </div>
                    </>)
                }
            </div>
        </>
    );
};

export default Operadores;
