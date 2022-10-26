import {useEffect, useState} from "react";
import {getDsOptions} from "../dynamic/api/api-service";

const getApi = (id) => getDsOptions("Usuarios", {
    pageSize: 1,
    filter: ["Id", "=", id],
    select: ["*", "datosPersonales"]
})

const useFetchOperadorAll = (id) => {
    const [isLoading, setIsLoading] = useState(true);
    const [isError, setIsError] = useState(false);
    const [data, setData] = useState(null);

    useEffect(() => {
        if(!id) {
            setIsLoading(false);
            return;
        }
        const load = async () => {
            try {
                const api = getApi(id);
                const [data] = await api.load();
                setData(data);
                setIsLoading(false);
            } catch (error) {
                setIsError(true);
                setIsLoading(false);
            }
        }
        load();
    }, [])

    return {isLoading, isError, data,};
};

export default useFetchOperadorAll;
