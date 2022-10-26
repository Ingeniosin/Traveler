import TuristasGrid from "./TuristasGrid";

const Turistas = () => {
    return (
        <>
            <h2>Información de los turistas</h2>

            <div className="mt-lg-3 bg-white rounded-5 shadow-lg p-lg-5 container position-relative">
                <TuristasGrid/>
            </div>
        </>
    );
};

export default Turistas;
