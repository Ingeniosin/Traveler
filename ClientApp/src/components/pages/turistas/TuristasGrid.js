import {useMemo, useRef} from "react";
import useCustomGrid from "../../../dynamic/devextreme/useDefaultDataGrid";
import {getDs, getDsLookup, getDsLookupForm, getDsOptions, getDsOptionsLookup} from "../../../dynamic/api/api-service";
import {Column, DataGrid, Editing, EmailRule, Form, Popup,} from 'devextreme-react/data-grid';
import {GroupItem, RequiredRule, SimpleItem} from 'devextreme-react/form';

const captions = {
    required: 'El campo es requerido.',

    datosPersonales: 'Datos Personales',
    origen: 'Origen',
    destino: 'Destino',
    llegoEnGrupo: 'Llego En Grupo',
    cantidadPersonasGrupo: 'Cantidad Personas Grupo',
    fechaLlegada: 'Fecha Llegada',
    fechaSalida: 'Fecha Salida',
    cantidadDias: 'Cantidad Dias',
    presupuesto: 'Presupuesto',
    fechaCreacion: 'Fecha Creacion',
    nombreCompleto: 'Nombre Completo',

    primerNombre: 'Primer Nombre',
    segundoNombre: 'Segundo Nombre',
    primerApellido: 'Primer Apellido',
    segundoApellido: 'Segundo Apellido',
    tipoDocumentoIdentidad: 'Tipo Documento Identidad',
    identificacion: 'Identificacion',
    fechaNacimiento: 'Fecha Nacimiento',
    genero: 'Genero',
    medioTransporte: 'Medio Transporte',
    correo: 'Correo electronico',

    pais: 'Pais',
    estado: 'Estado',
    ciudad: 'Ciudad',
    tipoTelefono: 'Tipo Telefono',

}

const labels = {
    datosPersonales: {text: captions['datosPersonales']},
    origen: {text: captions['origen']},
    destino: {text: captions['destino']},
    mediosTransporteLlegada: {text: captions['mediosTransporteLlegada']},
    mediosTransporteCiudad: {text: captions['mediosTransporteCiudad']},
    llegoEnGrupo: {text: captions['llegoEnGrupo'], alignment: 'center', location: 'left',},
    cantidadPersonasGrupo: {text: captions['cantidadPersonasGrupo']},
    fechaLlegada: {text: captions['fechaLlegada']},
    fechaSalida: {text: captions['fechaSalida']},
    presupuesto: {text: captions['presupuesto']},
    equipamiento: {text: captions['equipamiento']},
    fechaCreacion: {text: captions['fechaCreacion']},

    primerNombre: {text: captions['primerNombre']},
    segundoNombre: {text: captions['segundoNombre']},
    primerApellido: {text: captions['primerApellido']},
    segundoApellido: {text: captions['segundoApellido']},
    tipoDocumentoIdentidad: {text: captions['tipoDocumentoIdentidad']},
    identificacion: {text: captions['identificacion']},
    fechaNacimiento: {text: captions['fechaNacimiento']},
    genero: {text: captions['genero']},

    pais: {text: captions['pais']},
    estado: {text: captions['estado']},
    ciudad: {text: captions['ciudad']}

}


const columns = [
    {dataField: 'datosPersonales.nombreCompleto', dataType: 'string', caption: captions['nombreCompleto']},
    {dataField: 'motivoViajeId', dataType: 'number', caption: captions['motivoViaje'], required: true, lookup: getDsLookup('MotivosViaje', null, 'nombre')},
    {
        dataField: 'origenId',
        dataType: 'number',
        caption: captions['origen'],
        required: true,
        lookup: getDsLookup('Ubicaciones', null, 'ciudad')
    },
    {
        dataField: 'destinoId',
        dataType: 'number',
        caption: captions['destino'],
        required: true,
        lookup: getDsLookup('Ubicaciones', null, 'ciudad')
    },
    {dataField: 'presupuesto', dataType: 'number', caption: captions['presupuesto'], required: true},
    {
        dataField: 'fechaLlegada',
        dataType: 'date',
        caption: captions['fechaLlegada'],
        required: true,
        allowEditing: true
    },
    {dataField: 'fechaSalida', dataType: 'date', caption: captions['fechaSalida'], required: true},
    {dataField: 'fechaCreacion', dataType: 'date', caption: captions['fechaCreacion'], required: true},


    {dataField: 'llegoEnGrupo', dataType: 'boolean', caption: captions['llegoEnGrupo'], visible: false},
    {
        dataField: 'cantidadPersonasGrupo',
        dataType: 'number',
        caption: captions['cantidadPersonasGrupo'],
        visible: false
    },
    {dataField: 'origen.pais', dataType: 'string', caption: captions['pais'], required: true, visible: false},
    {dataField: 'origen.estado', dataType: 'string', caption: captions['estado'], required: true, visible: false},
    {dataField: 'origen.ciudad', dataType: 'string', caption: captions['ciudad'], required: true, visible: false},

    {dataField: 'destino.pais', dataType: 'string', caption: captions['pais'], required: true, visible: false},
    {dataField: 'destino.estado', dataType: 'string', caption: captions['estado'], required: true, visible: false},
    {dataField: 'destino.ciudad', dataType: 'string', caption: captions['ciudad'], required: true, visible: false},

    {
        dataField: 'datosPersonales.primerNombre',
        dataType: 'string',
        caption: captions['primerNombre'],
        required: true,
        visible: false
    },
    {
        dataField: 'datosPersonales.segundoNombre',
        dataType: 'string',
        caption: captions['segundoNombre'],
        required: false,
        visible: false
    },
    {
        dataField: 'datosPersonales.primerApellido',
        dataType: 'string',
        caption: captions['primerApellido'],
        required: true,
        visible: false
    },
    {
        dataField: 'datosPersonales.segundoApellido',
        dataType: 'string',
        caption: captions['segundoApellido'],
        required: false,
        visible: false
    },
    {
        dataField: 'datosPersonales.tipoDocumentoIdentidadId',
        dataType: 'number',
        caption: captions['tipoDocumentoIdentidad'],
        required: true,
        lookup: getDsLookup('TiposDocumentoIdentidad', null, 'nombre'),
        visible: false
    },
    {
        dataField: 'datosPersonales.identificacion',
        dataType: 'string',
        caption: captions['identificacion'],
        required: true,
        visible: false
    },
    {
        dataField: 'datosPersonales.fechaNacimiento',
        dataType: 'date',
        caption: captions['fechaNacimiento'],
        required: true,
        visible: false
    },
    {
        dataField: 'datosPersonales.generoId',
        dataType: 'number',
        caption: captions['genero'],
        required: true,
        lookup: getDsLookup('Generos', null, 'nombre'),
        visible: false
    },
    {dataField: 'mediosTransporteLlegada', dataType: 'object', caption: captions['presupuesto'], visible: false},
    {dataField: 'mediosTransporteCiudad', dataType: 'object', caption: captions['presupuesto'], visible: false},
    {dataField: 'equipamiento', dataType: 'object', caption: captions['presupuesto'], visible: false},
    {dataField: 'telefonos', dataType: 'object', visible: false},
    {dataField: 'correos', dataType: 'object', visible: false},
    {dataField: 'id', dataType: 'number', caption: captions['presupuesto'], required: false, visible: false},
]

const Grid = ({filter, reference}) => {
    const currentIndex = useRef(0)
    const configuration = useMemo(() => ({
        reference,
        columns,
        editorMode: 'cell',
        dataSource: {
            api: "Turistas",
            select: ["datosPersonales"],
            pageSize: 10,
            filter
        },
        ignore: ['defaultEditing'],
        otherConfigs: {
            onRowInserted: ({component}) => component.refresh(),
            onRowUpdated: ({component}) => component.refresh()
        },
        childs: (gridRef) => {
            return (
                <Editing mode="popup" allowUpdating={true} allowAdding={true} allowDeleting={true} useIcons={true} onEditRowKeyChange={(e) => {
                    const {instance} = gridRef.current;
                    const data = instance.getDataSource().items();
                    const [rowData] = data.filter((item) => item.id === e || item.__KEY__ === e);
                    currentIndex.current = {
                        key: e,
                        rowData: rowData || {},
                        index: () => instance.getRowIndexByKey(e)
                    }
                }} confirmDelete={""}>
                    <Popup resizeEnabled={true} title="Información del turista" showTitle={true} width={"70vw"} height={750} animation={{show: {type: "fade", from: 0, to: 1}, hide: {type: "fade", from: 1, to: 0}}}/>
                    <Form colCount={1} labelMode={"outlined"}>

                        <GroupItem caption="Información personal" colCount={2}>
                            <GroupItem colCount={4} colSpan={2}>
                                <SimpleItem dataField='datosPersonales.primerNombre' label={labels['primerNombre']} editorType='dxTextBox'>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                                <SimpleItem dataField='datosPersonales.segundoNombre' label={labels['segundoNombre']} editorType='dxTextBox'/>
                                <SimpleItem dataField='datosPersonales.primerApellido' label={labels['primerApellido']}
                                            editorType='dxTextBox'>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                                <SimpleItem dataField='datosPersonales.segundoApellido' label={labels['segundoApellido']} editorType='dxTextBox'/>
                            </GroupItem>
                            <GroupItem colCount={4} colSpan={2}>
                                <SimpleItem dataField='datosPersonales.tipoDocumentoIdentidadId'
                                            label={labels['tipoDocumentoIdentidad']} editorType='dxSelectBox'
                                            editorOptions={getDsLookupForm('TiposDocumentoIdentidad', null, 'nombre')}>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                                <SimpleItem dataField='datosPersonales.identificacion' label={labels['identificacion']}
                                            editorType='dxTextBox'>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                                <SimpleItem dataField='datosPersonales.generoId' label={labels['genero']}
                                            editorType='dxSelectBox'
                                            editorOptions={getDsLookupForm('Generos', null, 'nombre')}>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                                <SimpleItem dataField='datosPersonales.fechaNacimiento'
                                            label={labels['fechaNacimiento']} editorType='dxDateBox'>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                            </GroupItem>
                        </GroupItem>

                        <GroupItem colCount={2}>
                            <GroupItem caption="Información del origen" colCount={3}>
                                <SimpleItem dataField='origen.pais' label={labels['pais']} editorType='dxTextBox'>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                                <SimpleItem dataField='origen.estado' label={labels['estado']} editorType='dxTextBox'>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                                <SimpleItem dataField='origen.ciudad' label={labels['ciudad']} editorType='dxTextBox'>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                            </GroupItem>
                            <GroupItem caption="Información del destino" colCount={3}>
                                <SimpleItem dataField='destino.pais' label={labels['pais']} editorType='dxTextBox'>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                                <SimpleItem dataField='destino.estado' label={labels['estado']} editorType='dxTextBox'>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                                <SimpleItem dataField='destino.ciudad' label={labels['ciudad']} editorType='dxTextBox'>
                                    <RequiredRule message={captions['required']}/>
                                </SimpleItem>
                            </GroupItem>
                        </GroupItem>

                        <GroupItem caption="Información medios de transporte" colCount={2}>
                            <GroupItem caption="Llegada">
                                <SimpleItem component={() => {
                                    const {instance} = gridRef.current;
                                    const {index, rowData} = currentIndex.current;
                                    const {id} = rowData;


                                    const isNew = !id || id === 0;
                                    const onUpdate = e => {
                                        if (!isNew) return;
                                        instance.cellValue(index(), 'mediosTransporteLlegada', e.component.option('dataSource'))
                                    };
                                    const dataSource = isNew ? [] : getDsOptions("TuristasMediosTransporteLlegada", {filter: ["TuristaId", "=", id]});
                                    const onInitNewRow = e => e.data.turistaId = id;

                                    return (
                                        <div className="rounded-4 container px-4 pb-4 shadow">
                                            <DataGrid
                                                defaultEditing={{mode: 'cell', allowUpdating: true, allowAdding: true, allowDeleting: true, confirmDelete: false}}
                                                remoteOperations={true}
                                                dataSource={dataSource}
                                                onInitNewRow={onInitNewRow} onRowInserted={onUpdate} onRowUpdated={onUpdate} showBorders={true} showRowLines={true} rowAlternationEnabled={true}
                                                onRowRemoved={onUpdate}>
                                                <Column dataField="medioTransporteId" caption={captions['medioTransporte']} dataType="number" lookup={getDsLookup('MediosTransporte', {filter: ['EsLlegada', '=', true]}, 'nombre')}>
                                                    <RequiredRule message={captions['required']}/>
                                                </Column>
                                            </DataGrid>
                                        </div>
                                    )
                                }}/>
                            </GroupItem>

                            <GroupItem caption="En la ciudad">
                                <SimpleItem component={() => {
                                    const {instance} = gridRef.current;
                                    const {index, rowData, key} = currentIndex.current;
                                    const {id} = rowData;

                                    const isNew = !id || id === 0;
                                    const onUpdate = e => {
                                        if (!isNew) return;
                                        instance.cellValue(index(), 'mediosTransporteCiudad', e.component.option('dataSource'))
                                    };
                                    const dataSource = isNew ? [] : getDsOptions("TuristasMediosTransporteCiudad", {filter: ["TuristaId", "=", id]});
                                    const onInitNewRow = e => e.data.turistaId = id;



                                    return (
                                        <div className="rounded-4 container px-4 pb-4 shadow">
                                            <DataGrid
                                                defaultEditing={{mode: 'cell', allowUpdating: true, allowAdding: true, allowDeleting: true, confirmDelete: false}}
                                                remoteOperations={true}
                                                dataSource={dataSource}
                                                onInitNewRow={onInitNewRow} onRowInserted={onUpdate} onRowUpdated={onUpdate} showBorders={true} showRowLines={true} rowAlternationEnabled={true} onRowRemoved={onUpdate}>
                                                <Column dataField="medioTransporteId" caption={captions['medioTransporte']} dataType="number" lookup={getDsLookup('MediosTransporte', {filter: ['EsCiudad', '=', true]}, 'nombre')}>
                                                    <RequiredRule message={captions['required']}/>
                                                </Column>
                                            </DataGrid>
                                        </div>
                                    )
                                }}></SimpleItem>
                            </GroupItem>

                        </GroupItem>




                        <GroupItem caption="Información de contacto" colCount={6}>
                            <GroupItem colSpan={2} caption="Correos electronicos">
                                <SimpleItem component={() => {
                                    const {instance} = gridRef.current;
                                    const {index, rowData, key} = currentIndex.current;
                                    const {id} = rowData;

                                    const isNew = !id || id === 0;
                                    const onUpdate = e => {
                                        if (!isNew) return;
                                        instance.cellValue(index(), 'correos', e.component.option('dataSource'))
                                    };
                                    const dataSource = isNew ? [] : getDsOptions("TuristasCorreos", {filter: ["TuristaId", "=", id]});
                                    const onInitNewRow = e => e.data.turistaId = id;



                                    return (
                                        <div className="rounded-4 container px-4 pb-4 shadow">
                                            <DataGrid
                                                defaultEditing={{mode: 'cell', allowUpdating: true, allowAdding: true, allowDeleting: true, confirmDelete: false}}
                                                remoteOperations={true}
                                                dataSource={dataSource}
                                                onInitNewRow={onInitNewRow} onRowInserted={onUpdate} onRowUpdated={onUpdate} showBorders={true} showRowLines={true} rowAlternationEnabled={true}
                                                onRowRemoved={onUpdate}>
                                                <Column dataField="email" caption={captions['correo']} dataType="string">
                                                    <RequiredRule message={captions['required']}/>
                                                    <EmailRule message={"El correo electrónico no es válido"}/>
                                                </Column>
                                            </DataGrid>
                                        </div>
                                    )
                                }}/>
                            </GroupItem>

                            <GroupItem caption="Numeros telefonicos" colSpan={4}>
                                <SimpleItem component={() => {
                                    const {instance} = gridRef.current;
                                    const {index, rowData, key} = currentIndex.current;
                                    const {id} = rowData;

                                    const isNew = !id || id === 0;
                                    const onUpdate = e => {
                                        if (!isNew) return;
                                        instance.cellValue(index(), 'telefonos', e.component.option('dataSource'))
                                    };
                                    const dataSource = isNew ? [] : getDsOptions("TuristasTelefonos", {filter: ["TuristaId", "=", id]});
                                    const onInitNewRow = e => e.data.turistaId = id;


                                    return (
                                        <div className="rounded-4 container px-4 pb-4 shadow">
                                            <DataGrid
                                                defaultEditing={{mode: 'cell', allowUpdating: true, allowAdding: true, allowDeleting: true, confirmDelete: false}}
                                                remoteOperations={true}
                                                dataSource={dataSource}
                                                onInitNewRow={onInitNewRow} onRowInserted={onUpdate} onRowUpdated={onUpdate} showBorders={true} showRowLines={true} rowAlternationEnabled={true}
                                                onRowRemoved={onUpdate}>

                                                <Column dataField="numero" caption={captions['numero']} dataType="string">
                                                    <RequiredRule message={captions['required']}/>
                                                </Column>
                                                <Column dataField="tipoTelefonoId" caption={captions['tipoTelefono']} dataType="number" lookup={getDsLookup('TiposTelefono', null, 'nombre')}>
                                                    <RequiredRule message={captions['required']}/>
                                                </Column>
                                                <Column dataField="esWhatsapp" caption={captions['esWhatsapp']} dataType="boolean"/>
                                                <Column dataField="esLlamada" caption={captions['esLlamada']} dataType="boolean"/>
                                                <Column dataField="esSms" caption={captions['esSms']} dataType="boolean"/>
                                                <Column dataField="esPrincipal" caption={captions['esPrincipal']} dataType="boolean"/>
                                            </DataGrid>
                                        </div>
                                    )
                                }}/>
                            </GroupItem>

                        </GroupItem>


                        <GroupItem colCount={2}>

                            <GroupItem>
                                <GroupItem caption="Información de la estancia">
                                    <GroupItem colCount={2}>
                                        <SimpleItem dataField='fechaLlegada' label={labels['fechaLlegada']} editorType='dxDateBox'>
                                            <RequiredRule message={captions['required']}/>
                                        </SimpleItem>
                                        <SimpleItem dataField='fechaSalida' label={labels['fechaSalida']} editorType='dxDateBox'>
                                            <RequiredRule message={captions['required']}/>
                                        </SimpleItem>
                                    </GroupItem>
                                    <SimpleItem dataField='motivoViajeId' label={labels['motivoViaje']} editorType='dxSelectBox' editorOptions={getDsLookupForm('MotivosViaje', null, 'nombre')}>
                                        <RequiredRule message={captions['required']}/>
                                    </SimpleItem>
                                </GroupItem>

                                <GroupItem caption="Información adicional">
                                    <SimpleItem dataField='presupuesto' label={labels['presupuesto']} editorType='dxNumberBox' editorOptions={{
                                        format: 'currency',
                                        showClearButton: true,
                                        useLargeSpinButtons: false,
                                        showSpinButtons: false,
                                        min: 0,
                                    }}>
                                        <RequiredRule message={captions['required']}/>
                                    </SimpleItem>
                                    <GroupItem colCount={2}>
                                        <SimpleItem dataField='llegoEnGrupo' label={labels['llegoEnGrupo']} editorType='dxSwitch'/>
                                        <SimpleItem dataField='cantidadPersonasGrupo' label={labels['cantidadPersonasGrupo']} editorType='dxNumberBox'/>
                                    </GroupItem>
                                </GroupItem>




                            </GroupItem>

                            <GroupItem caption="Equipamiento">
                                <SimpleItem component={() => {

                                    const {instance} = gridRef.current;
                                    const {index, rowData, key} = currentIndex.current;
                                    const {id} = rowData;

                                    const isNew = !id || id === 0;
                                    const onUpdate = e => {
                                        if (!isNew) return;
                                        instance.cellValue(index(), 'equipamiento', e.component.option('dataSource'))
                                    };
                                    const dataSource = isNew ? [] : getDsOptions("TuristasEquipamiento", {filter: ["TuristaId", "=", id]});
                                    const onInitNewRow = e => e.data.turistaId = id;


                                    return (
                                        <div className="rounded-4 container px-4 pb-4 shadow">
                                            <DataGrid
                                                defaultEditing={{mode: 'cell', allowUpdating: true, allowAdding: true, allowDeleting: true, confirmDelete: false}}
                                                remoteOperations={true}
                                                dataSource={dataSource}
                                                onInitNewRow={onInitNewRow} onRowInserted={onUpdate} onRowUpdated={onUpdate} showBorders={true} showRowLines={true} rowAlternationEnabled={true}
                                                onRowRemoved={onUpdate}>
                                                <Column dataField="detalle" caption={captions['equipamiento']} dataType="string">
                                                    <RequiredRule message={captions['required']}/>
                                                </Column>
                                            </DataGrid>
                                        </div>
                                    )
                                }}/>
                            </GroupItem>

                        </GroupItem>




                    </Form>
                </Editing>
            )

        }
    }), [filter, reference]);
    return useCustomGrid(configuration)
};

export default Grid;