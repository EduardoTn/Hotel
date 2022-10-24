import { CCard, CCardHeader, CCardBody, CRow, CCol, CCardFooter, CButton } from '@coreui/react';
import React, { Component } from 'react';
import './Login.css';

interface Props {

}

interface State {
    user: string;
    password: string;
    backgroundURL: any;
}

class Login extends Component<Props, State>{
    constructor(props: Props) {
        super(props);
        this.state = {
            user: '',
            password: '',
            backgroundURL: new URL('./loginBackground.png', import.meta.url),
        }
    }

    changeUser(e: any) {
        this.setState({ user: e.target.value });
    }

    changePass(e: any) {
        this.setState({ password: e.target.value });
    }

    render() {
        return (
            <div className='login-container'>
                <img className='image-style' src={this.state.backgroundURL} />
                <CCard className='login-card-container'>
                    <CCardHeader style={{ backgroundColor: 'ivory' }}>
                        <h1>
                            Acessar
                        </h1>
                    </CCardHeader>
                    <CCardBody style={{ backgroundColor: 'ivory' }}>
                        <CRow className='d-flex justify-content-center input-row'>
                            <input className='input-login' type='text' onChange={(e) => this.changeUser(e)} value={this.state.user} placeholder='Digite seu Email' />
                        </CRow>
                        <CRow className='d-flex justify-content-center input-row'>
                            <input className='input-login' type='password' onChange={(e) => this.changePass(e)} value={this.state.password} placeholder='Digite sua Senha' />
                        </CRow>
                    </CCardBody>
                    <CCardFooter style={{ backgroundColor: 'ivory' }}>
                        <CRow>
                            <CCol sm={6} className='d-flex justify-content-start'>
                                <CButton color='link'>
                                    Primeira vez?
                                </CButton>
                            </CCol>
                            <CCol sm={6} className='d-flex justify-content-end'>
                                <CButton className='changeHover'>
                                    Entrar
                                </CButton>
                            </CCol>
                        </CRow>
                    </CCardFooter>
                </CCard>
            </div>
        );
    }
}

export default Login;