import { useState, useEffect } from "react";
import { Form, FormGroup, Input, Button } from "reactstrap";
import AsideListado from './AsideListado';
import './Style.css';

const modelo = {
    aside_Pk: "",
    aside_Titulo: "",
    aside_Descripcion: "",
    aside_Contenido: "",
    aside_Estado: 0,
    aside_Orden: 0,
    Company_Pk: "",
    file_Nombre: "",
    file_Base64: "",
    file_Tamanio: "",
    audit_UsuCre: "",
    audit_FecCre: "",
    audit_UsuAct: "",
    audit_FecAct: ""
}
const modelo_user = {
    user_Pk: "",
    user_Nombre: "",
    user_Direccion: "",
    user_Telefono: 0,
    user_Email: "",
    user_Token: "",
    user_Estado: 0,
    plan_Pk: "",
    rol_Pk: "",
    audit_UsuCre: "",
    audit_FecCre: "",
    audit_UsuAct: "",
    audit_FecAct: ""
}
const AsideRegistro = () => {
    const [modeloCreate, setmodeloCreate] = useState(modelo);
    const [user] = useState(window.localStorage.getItem("sesion_user"))
    const [dataUser, setDataUser] = useState(modelo_user)

    useEffect(() => {
        let dt = JSON.parse(user)
        setDataUser(dt)
    }, [])

    const actualizaDato = (e) => {
        setmodeloCreate(
            {
                ...modeloCreate,
                [e.target.name]: e.target.value
            }
        )
    }
    const enviarDatos = () => {
        modeloCreate.audit_UsuCre = dataUser.user_Nombre
        registrar(modeloCreate)
    }
    const registrar = async (modeloCreate) => {
        const response = await fetch("api/aside/registro", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(modeloCreate)
        })
        if (response.ok) {
            window.location.reload();
        }
    }
    async function cargarArchivo(e) {
        let index = 0;
        let nombre = e.target.files[index].name;
        if (nombre.length > 1) {
            let tamanio = e.target.files[index].size.toString();
            if (tamanio > 1) {
                if (tamanio < 5120000) {
                    let next = nombre.lastIndexOf('.');
                    let extension = nombre.substring(next + 1);
                    if (extension === "jpg" || extension === "png" || extension === "jpeg" || extension === "gif") {
                        const myBlob = e.target.files[index];
                        const myB64 = await blobToBase64(myBlob);
                        modeloCreate.file_Base64 = myB64;
                        modeloCreate.file_Nombre = nombre;
                        modeloCreate.file_Tamanio = tamanio;
                        console.log(modeloCreate);
                    } else { alert("Archivo Invalido!. No tiene formato de imagen solicitado"); }
                } else { alert("Archivo Invalido!. Supera el limite 5MB"); }
            } else { alert("Archivo Invalido!. No tiene contenido"); }
        } else { alert("Archivo Invalido!. No tiene nombre"); }
    }
    const blobToBase64 = (blob) => {
        return new Promise((resolve, reject) => {
            const reader = new FileReader();
            reader.readAsDataURL(blob);
            reader.onloadend = () => {
                resolve(reader.result.split(',')[1]);
            };
        });
    };
    const ocultarForm = () => {
        document.getElementById('form_registro').style.display = 'none';
        document.getElementById('group_filtro').style.display = 'block';
    }
    const mostrarForm = () => {
        document.getElementById('group_filtro').style.display = 'none';
        document.getElementById('form_registro').style.display = 'block';
    }
    return (
        <div id="comp_aside">
            <h3 >Gestion de Aside</h3>
            <Form id="form_registro"><br />
                <FormGroup className="d-flex flex-row ">
                    <label className="me-2" >Titulo</label>
                    <Input id="txt_titulo" name="aside_Titulo" onChange={(e) => actualizaDato(e)}
                        value={modeloCreate.aside_Titulo}></Input>
                </FormGroup>
                <FormGroup className="d-flex flex-row">
                    <label className="me-2">Descripcion</label>
                    <Input id="txtDesc" name="aside_Descripcion" onChange={(e) => actualizaDato(e)}
                        value={modeloCreate.aside_Descripcion}></Input>
                </FormGroup>
                <FormGroup className="d-flex flex-row">
                    <label className="me-2">Contenido</label>
                    <textarea id="txa_contenido" name="aside_Contenido"
                        onChange={(e) => actualizaDato(e)} className="form-control"
                        value={modeloCreate.aside_Contenido}></textarea>
                </FormGroup>
                <div className="d-flex flex-row ">
                    <FormGroup className="d-flex flex-row">
                        <label className="me-2">Orden</label>
                        <Input id="txtOrden" name="aside_Orden" onChange={(e) => actualizaDato(e)}
                            value={modeloCreate.aside_Orden}></Input>
                    </FormGroup>
                    <FormGroup className="d-flex flex-row">
                        <label className="me-1">Imagen</label>
                        <input type="file" accept=".jpg,.png,.gif" onChange={(e) => cargarArchivo(e)} />
                    </FormGroup>
                    <FormGroup >
                        <Button id="btnRegistrar" onClick={enviarDatos} className="btn btn-success ms-5">Registrar</Button>
                        <Button id="btnOcultar" onClick={ocultarForm} className="btn btn-danger ms-5">Ocultar</Button>
                    </FormGroup>
                </div>
            </Form>
            <div id="group_filtro" className="d-flex flex-row">
                <FormGroup className="d-flex flex-row busqueda" >
                    <label className="me-2">Busqueda</label>
                    <Input id="txtBusqueda" ></Input>
                </FormGroup>
                <FormGroup >
                    <Button id="btnMostrar" onClick={mostrarForm} className="btn btn-warning ms-5">Nuevo</Button>
                </FormGroup>
            </div>
            <br></br>
            <AsideListado />
        </div>
    )
}

export default AsideRegistro;