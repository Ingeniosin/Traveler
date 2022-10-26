import {useEffect, useState} from "react";
import {getDsOptions} from "../dynamic/api/api-service";

const getApi = (id) => getDsOptions("Usuarios", {
    pageSize: 1,
    filter: ["Id", "=", id],
    select: ["*", "rol.nombre", "datosPersonales.nombreCompleto", "datosPersonales.identificacion", "datosPersonales.tipoDocumentoIdentidad.nombre", "datosPersonales.genero.nombre"]
})

const useFetchOperador = (id) => {
    const [isLoading, setIsLoading] = useState(true);
    const [isError, setIsError] = useState(false);
    const [data, setData] = useState(null);

    useEffect(() => {
        const load = async () => {
            if(data != null) return;
            try {
                const api = getApi(id);
                const [data] = await api.load();
                setData(data);
                setIsError(!data);
            } catch (error) {
                setIsError(true);
            }
            setIsLoading(false);
        }
        load();
    }, [data, id])

    return {
        isLoading,
        isError,
        data,
        refetch: () => {
            setIsLoading(true);
            setIsError(false);
            setData(null);
        }
    };
};

export default useFetchOperador;
