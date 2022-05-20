import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Tarjeta } from 'src/app/Models/tarjeta';
import { TarjetaCreditoService } from '../../Services/tarjeta-credito.service'

@Component({
  selector: 'app-credit-card',
  templateUrl: './credit-card.component.html',
  styleUrls: ['./credit-card.component.css']
})
export class CreditCardComponent implements OnInit {

  listTarjetas : Tarjeta;
  idModifTarjeta : number = undefined;
  accion : string = "Agregar";

  form: FormGroup;

  constructor(private formBuilder: FormBuilder, private toastr: ToastrService, private tarjetaService : TarjetaCreditoService) {
    this.form = this.formBuilder.group({
      Nombre:['',  [Validators.required, Validators.minLength(10), Validators.maxLength(20)]],
      numeroTarjeta:['', [Validators.required, Validators.minLength(16), Validators.maxLength(16)]],
      fechaExp:['' , [Validators.required, Validators.minLength(1)]],
      cvv:['', [Validators.required, Validators.min(1), Validators.max(999)]]
    })
   }

  ngOnInit(): void {
    this.getTarjetas();
  }

  getTarjetas(){
    this.tarjetaService.getAllTarjetas().subscribe( data => {
      console.log(data);
      this.listTarjetas = data;
      this.toastr.info('Consulta de Tarjetas Correctas', 'Consulta!');
    }, 
    error => {
      console.log(error);
    });

  }

  SendData(){

    let tarjeta : any = {
      Nombre: this.form.value["Nombre"],
      numeroTarjeta: this.form.value["numeroTarjeta"],
      fechaExp: this.form.value["fechaExp"],
      cvv: this.form.value["cvv"] 
    }

    if(this.idModifTarjeta != undefined){

      tarjeta.id =  this.idModifTarjeta;

      this.tarjetaService.modificarTarjeta(this.idModifTarjeta, tarjeta).subscribe( data => {

        this.toastr.success('Se Modifico la tarjeta correctamente! ', 'Modificado Exitoso!');
        this.getTarjetas();
        this.form.reset();
  
      }, error => {
        console.log(error);
        this.toastr.error('Error al Agregar la tarjeta!', 'Error!');
      });


    } else{

    console.log(tarjeta);

    this.tarjetaService.GuardarTarjeta(tarjeta).subscribe( data => {

      this.toastr.success('Se guardo la tarjeta correctamente! ', 'Guardado Exitoso!');
      this.getTarjetas();
      this.form.reset();

    }, error => {
      console.log(error);
      this.toastr.error('Error al Agregar la tarjeta!', 'Error!');
    });
          }

  }


  eliminarTarjeta(_tarjetaDelete : Tarjeta){
    console.log(_tarjetaDelete.id);

    this.tarjetaService.eliminarTarjeta(_tarjetaDelete.id).subscribe( data => {
      
      this.toastr.warning('La tarjeta fue eliminada correctamente!', 'Tarjeta Eliminada!');
      this.getTarjetas();
    }, 
    error => {
      console.log(error);
      this.toastr.error('Error al eliminar la tarjeta', 'Error');
    });

  }

  modificarTarjeta(tarjeta:any){

    this.form.controls["Nombre"].setValue(tarjeta.nombre);
    this.form.controls["numeroTarjeta"].setValue(tarjeta.numeroTarjeta)
    this.form.controls["fechaExp"].setValue(tarjeta.fechaExp)
    this.form.controls["cvv"].setValue(tarjeta.cvv);

    this.idModifTarjeta = tarjeta.id;
    this.accion = "Modificar"; 
    
  }

}
