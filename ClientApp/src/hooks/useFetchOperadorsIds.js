import {useEffect, useState} from "react";
import {getDsOptions} from "../dynamic/api/api-service";

const api = getDsOptions("Usuarios", {
    pageSize: 9999,
    select: ["id"]
})

const useFetchOperadorsIds = () => {
    const [isLoading, setIsLoading] = useState(true);
    const [isError, setIsError] = useState(false);
    const [data, setData] = useState(null);

    useEffect(() => {
        if(data != null) return;
        const load = async () => {
            try {
                const data = await api.load();
                setData(data.map(x => x.id));
                setIsLoading(false);
            } catch (error) {
                setIsError(true);
                setIsLoading(false);
            }
        }
        load();
    }, [data])

    return {isLoading, isError, data, refetch: () => {
        setIsLoading(true);
        setIsError(false);
        setData(null);
    }}
};

export default useFetchOperadorsIds;
