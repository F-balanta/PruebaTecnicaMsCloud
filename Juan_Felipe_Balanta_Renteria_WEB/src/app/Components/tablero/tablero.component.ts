import { Component, OnInit } from '@angular/core';
import {TableroService} from "../../services/tablero.service";
import {Tablero, ITablero} from "../../Models/tablero.model";

@Component({
  selector: 'app-tablero',
  templateUrl: './tablero.component.html',
  styleUrls: ['./tablero.component.scss']
})
export class TableroComponent implements OnInit {
  tablero: Tablero = new Tablero
  datatable: ITablero[] = [];
  constructor(
    private apiService: TableroService
  ) { }

  ngOnInit(): void {
    this.getAlldata()
  }

  getAlldata(){
    this.apiService.getAllTablero()
      .subscribe(data=>{
        this.datatable = data
        console.log(this.datatable);
      });
  }
  clearFields(){
    this.tablero.id = 0;
    this.tablero.nombre = "";
    this.tablero.pais = "";
    this.tablero.arranque = 0;
    this.tablero.envion = 0;
    this.tablero.totalPeso = 0;
  }
  addNewTablero(tablero: ITablero){
    if (tablero.pais != "" && tablero.nombre != ""){
      this.apiService.addTablero(tablero)
        .subscribe(data=>{
          if(data){
            this.clearFields();
            this.getAlldata();
          }
        })
    }
  }

  getDataToEdit(selectedItem:any){
    this.tablero.id = selectedItem.id;
    this.tablero.pais = selectedItem.pais;
    this.tablero.nombre = selectedItem.nombre;
    this.tablero.arranque = selectedItem.arranque;
    this.tablero.envion = selectedItem.envion;
    this.tablero.totalPeso = selectedItem.totalPeso;

  }

}
