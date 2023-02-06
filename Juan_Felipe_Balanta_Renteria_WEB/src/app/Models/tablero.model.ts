export interface ITablero{
  "id": number,
  "pais": string,
  "nombre": string,
  "arranque": number,
  "envion": number,
  "totalPeso": number
}

export class Tablero{
  id: number = 0;
  pais:string = "";
  nombre: string = "";
  arranque: number = 0;
  envion: number = 0;
  totalPeso: number = 0;
}
