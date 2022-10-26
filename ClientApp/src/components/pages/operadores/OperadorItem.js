import useFetchOperador from "../../../hooks/useFetchOperador";
import LoadingSpinner from "../../../dynamic/devextreme/LoadingSpinner";
import operador from '../../../assets/operador.svg';
import {Button, Popup} from "devextreme-react";
import {useState} from "react";
import FormOperador from "./form/FormOperador";
import {getDs} from "../../../dynamic/api/api-service";

const OperadorItem = ({id}) => {
    const {isLoading, isError, data, refetch} = useFetchOperador(id);
    const [visiblePopup, setVisiblePopup] = useState(false);
    if(isError) return null;


    return (
        <div className="shadow-lg rounded-5 p-3 col-lg-3 col-md-6 col-sm-12 d-flex flex-column align-items-center justify-content-center text-center position-relative" style={{
            cursor: 'pointer',
        }}>
            {
                isLoading ? <LoadingSpinner/> :(<>

                    <Button className="position-absolute end-0 top-0 m-3" icon="trash" type="text" onClick={() => {
                        getDs("Usuarios").remove(data.id).then(refetch);

                    }}/>

                    <div  onClick={() => setVisiblePopup(true)}>
                        <img src={operador} alt="operador" style={{width: "50px",}}/>
                        <h6 className="mt-3 fw-bold">{data.datosPersonales.nombreCompleto}</h6>
                        <p className="m-0"><strong>Identificación:</strong> {data.datosPersonales.tipoDocumentoIdentidad.nombre} - {data.datosPersonales.identificacion}</p>
                        <p className="m-0"><strong>Correo electronico:</strong> {data.correo}</p>
                        <p className="m-0"><strong>Rol:</strong> {data.rol.nombre}</p>
                        <p className="m-0"><strong>Genero:</strong> {data.datosPersonales.genero.nombre}</p>

                        <Popup title={"Editar un operador"} height={"auto"} width={"850px"} showTitle={true} visible={visiblePopup} resizeEnabled={true} showCloseButton={true} deferRendering={true} onHiding={() => setVisiblePopup(false)} closeOnOutsideClick={true}>
                            <div className="p-2">
                                <FormOperador id={id} onSave={() => {
                                    setVisiblePopup(false);
                                    refetch();
                                }}/>
                            </div>
                        </Popup>
                    </div>
                </>)
            }
        </div>
    );
};

export default OperadorItem;
