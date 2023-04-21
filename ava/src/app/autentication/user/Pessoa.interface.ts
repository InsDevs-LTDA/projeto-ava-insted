export interface Pessoa {
  user: {
    "idUser": number,
    "idAddress": number,
    "nmUser": string,
    "nrRegister": string,
    "nrCpf": string,
    "nrRg": number,
    "nmExpedition": string,
    "dtBirthdate": Date,
    "nmSex": string,
    "nmPhone1": string,
    "nmPhone2": string,
    "nmEmail": string,
    "nmPassword": string,
    "imgFile": string,
    "snTeacher": boolean,
  } | null
}
