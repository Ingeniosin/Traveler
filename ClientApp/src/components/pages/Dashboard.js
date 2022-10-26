import {useState} from "react";
import {getDs} from "../../dynamic/api/api-service";
import TuristasGrid from "./turistas/TuristasGrid";
import {Chart} from "devextreme-react";
import {Series, Size} from "devextreme-react/chart";

const Dashboard = () => {
    return (
        <>
            <h1>Dashboard</h1>
            <div className="mt-lg-3 bg-white rounded-5 shadow-lg p-lg-5 container position-relative">
                <div className="row">
                    <ChartOrigenes/>
                    <ChartTMes/>
                    <ChartOtros/>
                </div>
            </div>
        </>
    );
};

const ChartOrigenes = () => {
    const [data, setData] = useState();
    const [loading, setLoading] = useState(true);

    useState(() => {
        const load = async () => {
            const response = await getDs("GetChartOf").insert({ChartName: "ciudadorigen"});
            setData(response);
            setLoading(false);
        }
        load();
    }, [])

    if(loading) return <div>Cargando...</div>

    return (
        <>
            <div className="card col-lg-4 p-4 rounded-5">
                <h6 className="text-center fw-bold mb-4">Ciudades de origen mas recurrentes</h6>
                <Chart id="chart" dataSource={data} height={200} width={400}>
                    <Series valueField="value" width={"350px"} argumentField="name" name="Ciudad" type="bar" color="#ffaa66" />
                    <Size height={200} width={350}/>
                </Chart>
            </div>
        </>
    );
};

const ChartTMes = () => {
    const [data, setData] = useState();
    const [loading, setLoading] = useState(true);

    useState(() => {
        const load = async () => {
            const response = await getDs("GetChartOf").insert({ChartName: "cantidadtmes"});
            setData(response);
            setLoading(false);
        }
        load();
    }, [])

    if(loading) return <div>Cargando...</div>

    return (
        <>
            <div className="card col-lg-4 p-4 rounded-5">
                <h6 className="text-center fw-bold mb-4">Cantidad de turistas por mes</h6>
                <Chart id="chart" dataSource={data} height={200} width={400}>
                    <Series valueField="value" width={"350px"} argumentField="name" name="Ciudad" type="bar" color="#ffaa66" />
                    <Size height={200} width={350}/>
                </Chart>
            </div>
        </>
    );
}

const ChartOtros = () => {
    const [data, setData] = useState();
    const [loading, setLoading] = useState(true);

    useState(() => {
        const load = async () => {
            const response = await getDs("GetChartOf").insert({ChartName: "otrasestadisticas"});
            setData(response);
            setLoading(false);
        }
        load();
    }, [])

    if(loading) return <div>Cargando...</div>

    return (
        <>
            <div className="card col-lg-4 p-4 rounded-5">
                <h6 className="text-center fw-bold mb-4">Otras estadisticas</h6>

                <div className="text-center">

                    <p><strong>Promedio de gastos por turista: </strong>{data.promGasto.toLocaleString('en-US', {
                        style: 'currency',
                        currency: 'COP',
                    })}</p>
                    <p><strong>Promedio de edad por turista: </strong>{data.promEdad} años</p>
                    <p><strong>Promedio de días hospedados por turista: </strong>{data.promDiasHospedado} días</p>

                </div>

            </div>
        </>
    );
}

export default Dashboard;
