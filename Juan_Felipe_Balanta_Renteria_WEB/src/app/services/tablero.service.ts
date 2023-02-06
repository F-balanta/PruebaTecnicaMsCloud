import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ITablero} from "../Models/tablero.model";

@Injectable({
  providedIn: 'root'
})
export class TableroService {

  apiUrl = "https://localhost:7239/api/tableros";
  constructor(
    private http : HttpClient
  ) { }

  getAllTablero(){
    return this.http.get<ITablero[]>(`${this.apiUrl}/obtener`);
  }

  getTablerobyId(id:number){
    return this.http.get<ITablero>(`${this.apiUrl}/obtener`+ id);
  }

  addTablero(tablero:ITablero){
    return this.http.post(`${this.apiUrl}`+ "/" + "crear" , tablero);
  }

  updateTablero(tablero:ITablero){
    return this.http.put(`${this.apiUrl}/crear` , tablero);
  }

  deleteTablero(id: number){
    return this.http.delete(`${this.apiUrl}/eliminar`+ id);
  }

}
