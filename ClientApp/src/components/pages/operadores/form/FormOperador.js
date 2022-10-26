import {ButtonItem, GroupItem, RequiredRule, SimpleItem} from "devextreme-react/form";
import {useCallback, useRef} from "react";
import {toast} from "react-hot-toast";
import CustomForm from "../../../../dynamic/devextreme/CustomForm";
import {getDs, getDsLookupForm} from "../../../../dynamic/api/api-service";
import useFetchOperadorAll from "../../../../hooks/useFetchOperadorAll";

const captions = {
    required: 'El campo es requerido.',
    nombreCompleto: 'Nombre Completo',
    correo: 'Correo',
    esActivo: 'Es Activo',
    rol: 'Rol',
    datosPersonales: 'Datos Personales',
    ultimoAcceso: 'Ultimo Acceso',
    fechaCreacion: 'Fecha Creacion',

    primerNombre: 'Primer Nombre',
    segundoNombre: 'Segundo Nombre',
    primerApellido: 'Primer Apellido',
    segundoApellido: 'Segundo Apellido',
    tipoDocumentoIdentidad: 'Tipo Documento Identidad',
    identificacion: 'Identificacion',
    fechaNacimiento: 'Fecha Nacimiento',
    genero: 'Genero'

}

const labels = {
    correo: {text: captions['correo']},
    esActivo: {text: captions['esActivo'],  alignment: 'center', location: 'left',},
    rol: {text: captions['rol']},
    datosPersonales: {text: captions['datosPersonales']},
    ultimoAcceso: {text: captions['ultimoAcceso']},
    fechaCreacion: {text: captions['fechaCreacion']},

    primerNombre: {text: captions['primerNombre']},
    segundoNombre: {text: captions['segundoNombre']},
    primerApellido: {text: captions['primerApellido']},
    segundoApellido: {text: captions['segundoApellido']},
    tipoDocumentoIdentidad: {text: captions['tipoDocumentoIdentidad']},
    identificacion: {text: captions['identificacion']},
    fechaNacimiento: {text: captions['fechaNacimiento']},
    genero: {text: captions['genero']}

}

const messages = {
    loading: 'Guardando registro...',
    success: 'Registro enviado correctamente',
    error: e => 'Ocurrio un error al enviar el registro ' + e
}

const Form = ({id, onSave}) => {
    const formRef = useRef(null)
    const {isLoading, isError, data,} = useFetchOperadorAll(id);

    const submit = useCallback(async () => {
        const {isValidAsync, getData} = formRef.current;
        const isValid = await isValidAsync();
        if(!isValid) return;
        const data = getData();
        const ds = getDs("Usuarios");
        await toast.promise(data.id && data.id > 0 ? ds.update(data.id, data) : ds.insert(data), messages);
        if(onSave){
            await onSave();
        }
    }, [])

    if(isLoading || isError) return null;

    return (
        <CustomForm onEnterKey={submit} reference={formRef} formOptions={{colCount: 1}} defaultFormData={{
            ...(data || {}),
            esActivo: data?.esActivo ?? true
        }}>

            <GroupItem caption={"Información del usuario"} colCount={3}>
                <SimpleItem dataField='correo' label={labels['correo']} editorType='dxTextBox'>
                    <RequiredRule message={captions['required']} />
                </SimpleItem>
                <SimpleItem dataField='rolId' label={labels['rol']} editorType='dxSelectBox' editorOptions={getDsLookupForm('Roles', null, 'nombre')}>
                    <RequiredRule message={captions['required']} />
                </SimpleItem>
                <SimpleItem dataField='esActivo' label={labels['esActivo']} editorType='dxSwitch'/>
            </GroupItem>

            <GroupItem caption="Información personal" colCount={2}>
                <GroupItem colCount={4} colSpan={2}>
                    <SimpleItem dataField='datosPersonales.primerNombre' label={labels['primerNombre']} editorType='dxTextBox'>
                        <RequiredRule message={captions['required']} />
                    </SimpleItem>
                    <SimpleItem dataField='datosPersonales.segundoNombre' label={labels['segundoNombre']} editorType='dxTextBox'/>
                    <SimpleItem dataField='datosPersonales.primerApellido' label={labels['primerApellido']} editorType='dxTextBox'>
                        <RequiredRule message={captions['required']} />
                    </SimpleItem>
                    <SimpleItem dataField='datosPersonales.segundoApellido' label={labels['segundoApellido']} editorType='dxTextBox'/>
                </GroupItem>

                <GroupItem colCount={4} colSpan={2}>
                    <SimpleItem dataField='datosPersonales.tipoDocumentoIdentidadId' label={labels['tipoDocumentoIdentidad']} editorType='dxSelectBox' editorOptions={getDsLookupForm('TiposDocumentoIdentidad', null, 'nombre')}>
                        <RequiredRule message={captions['required']} />
                    </SimpleItem>
                    <SimpleItem dataField='datosPersonales.identificacion' label={labels['identificacion']} editorType='dxTextBox'>
                        <RequiredRule message={captions['required']} />
                    </SimpleItem>
                    <SimpleItem dataField='datosPersonales.generoId' label={labels['genero']} editorType='dxSelectBox' editorOptions={getDsLookupForm('Generos', null, 'nombre')}>
                        <RequiredRule message={captions['required']} />
                    </SimpleItem>
                    <SimpleItem dataField='datosPersonales.fechaNacimiento'  label={labels['fechaNacimiento']} editorType='dxDateBox'>
                        <RequiredRule message={captions['required']} />
                    </SimpleItem>
                </GroupItem>

            </GroupItem>


            <ButtonItem horizontalAlignment="center" buttonOptions={{text: 'Guardar', type: 'default', onClick: submit}}/>
        </CustomForm>
    );
};

export default Form;
