<template>
    <div>
        <h1 class="display-4 text-center">Task List</h1>
        <hr>
        <div class="row">
            <div class="col-lg-8 offset-lg-2">
                <div class="card mt-4">
                    <div class="card-body">
                        <div class="input-group">
                            <input type="text" v-model = 'task'
                             class="form-control form-control-lg" placeholder="Add task">
                            <div class="input-group-append">
                                <button v-on:click="addTask()"
                                class="btn btn-success btn-lg">Add</button>
                            </div>
                        </div>
                        <br>
                        {{taskList}}
                        <h5 v-if= "taskList.length ==0">No task yet</h5>    
                        <ul class="list-group">
                            <li v-for="(task, index) of taskList" :key = "index"
                                class="list-group-item d-flex justify-content-around">
                                <span class="cursor" v-on:click = "editTask(task, index)" >
                                    <i v-bind:class= "[task.state ?   'fa-solid fa-square-check': 'fa-regular fa-square' ] "></i> 
                                     <!-- <i class="fa-solid fa-square-check"></i>  -->
                                </span>
                                {{task.name}}
                                <span class="cursor text-danger" v-on:click="deleteTask(index)">
                                     <i class="fa-solid fa-trash"></i>
                                </span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'TaskComponent',
        data(){
            return{
                task: '',
                taskList: []
            }
        },
        methods: {
            addTask() {
                const myTask = {
                    name: this.task,
                    state: false
                }
                this.taskList.push(myTask);
                this.myTask = '';
            },
            deleteTask(index){
                this.taskList.splice(index, 1)
            },
            editTask(task, index){
                this.taskList[index].state = !task.state;
            }
        }
    }
</script>

<style  scoped>
.cursor{
    cursor: pointer;
}
</style>