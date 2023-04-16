export interface LoginInterface {
  ra?: string;
  password?: string;
  email?: string;
  cpf?: string;
}

export interface ResponseInterface {

  success: boolean;
  message: string;
  token: string
}
